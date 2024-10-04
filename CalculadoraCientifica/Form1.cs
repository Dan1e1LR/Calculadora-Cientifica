using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;
using System.Text.Json;

namespace CalculadoraCientifica
{
    public partial class Form1 : Form
    {
        private bool inicioNuevoNumero = true;

        private const string GITHUB_API_URL = "https://api.github.com/repos/Dan1e1LR/Calculadora-Cientifica/releases/latest";
        private const string CURRENT_VERSION = "1.1.0"; // Asegúrate de cambiar esto a la versión actual de tu aplicación
        public Form1()
        {
            InitializeComponent();
        }

        //Boton de actualizar la aplicacion
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (HayNuevaVersion())
            {
                if (MessageBox.Show("Hay una nueva versión disponible. ¿Desea actualizar?", "Actualización", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DescargarYEjecutarNuevaVersion();
                }
            }
            else
            {
                MessageBox.Show("No hay actualizaciones disponibles.", "Actualización");
            }
        }
        private bool HayNuevaVersion()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add("User-Agent", "Calculadora-Figuras");
                    string json = client.DownloadString(GITHUB_API_URL);

                    // Parseo manual del JSON
                    int tagIndex = json.IndexOf("\"tag_name\":");
                    if (tagIndex == -1)
                    {
                        MessageBox.Show("No se pudo encontrar información de versión en la respuesta de GitHub.", "Error");
                        return false;
                    }

                    int startIndex = json.IndexOf("\"", tagIndex + 11) + 1;
                    int endIndex = json.IndexOf("\"", startIndex);
                    string latestVersion = json.Substring(startIndex, endIndex - startIndex);

                    Console.WriteLine($"Versión actual: {CURRENT_VERSION}, Última versión: {latestVersion}");
                    return CompareVersions(latestVersion, CURRENT_VERSION) > 0;
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response is HttpWebResponse response)
                {
                    if (response.StatusCode == HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("No se encontró la página de releases. Verifica la URL del repositorio.", "Error");
                    }
                    else
                    {
                        MessageBox.Show($"Error de servidor: {response.StatusCode}", "Error");
                    }
                }
                else
                {
                    MessageBox.Show($"Error de conexión: {ex.Message}", "Error");
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado al verificar actualizaciones: {ex.Message}", "Error");
                return false;
            }
        }
        private void DescargarYEjecutarNuevaVersion()
        {
            FormActualizacion formActualizacion = new FormActualizacion();
            formActualizacion.Show();

            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add("User-Agent", "request");
                    string json = client.DownloadString(GITHUB_API_URL);
                    var releaseInfo = JsonSerializer.Deserialize<JsonElement>(json);
                    string downloadUrl = releaseInfo.GetProperty("assets")[0].GetProperty("browser_download_url").GetString();
                    string tempPath = Path.GetTempPath();
                    string nuevaVersionPath = Path.Combine(tempPath, "NuevaCalculadora_temp.exe");

                    client.DownloadProgressChanged += (s, e) =>
                    {
                        formActualizacion.ActualizarProgreso(e.ProgressPercentage);
                    };

                    client.DownloadFileCompleted += (s, e) =>
                    {
                        formActualizacion.Close();
                        if (e.Error == null)
                        {
                            CrearYEjecutarScriptActualizacion(nuevaVersionPath);
                        }
                        else
                        {
                            MessageBox.Show($"Error al descargar la nueva versión: {e.Error.Message}", "Error");
                        }
                    };

                    client.DownloadFileAsync(new Uri(downloadUrl), nuevaVersionPath);
                }
            }
            catch (Exception ex)
            {
                formActualizacion.Close();
                MessageBox.Show($"Error al preparar la descarga: {ex.Message}", "Error");
            }
        }

        private void CrearYEjecutarScriptActualizacion(string nuevaVersionPath)
        {
            string appPath = Application.ExecutablePath;
            string scriptPath = Path.Combine(Path.GetTempPath(), "actualizar.bat");
            string scriptContent = $@"
@echo off
timeout /t 2 /nobreak
taskkill /F /IM ""{Path.GetFileName(appPath)}""
timeout /t 2 /nobreak
move /Y ""{nuevaVersionPath}"" ""{appPath}""
start """" ""{appPath}""
del ""%~f0""
";

            File.WriteAllText(scriptPath, scriptContent);

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = scriptPath,
                CreateNoWindow = true,
                UseShellExecute = true,
                WindowStyle = ProcessWindowStyle.Hidden
            };

            Process.Start(psi);
            Application.Exit();
        }

        private int CompareVersions(string v1, string v2)
        {
            v1 = v1.TrimStart('v');
            v2 = v2.TrimStart('v');
            return new Version(v1).CompareTo(new Version(v2));
        }
        private void Calcular_Click(object sender, EventArgs e)
        {
            string operacion = Resultado.Text;
            string operacionHistorial = Resultado.Text;

            try
            {
                // Reemplazar constantes y operadores
                operacion = operacion.Replace("π", Math.PI.ToString());
                operacion = Regex.Replace(operacion, @"(?<=\d|\))x(?=\d|\()", "*");
                operacion = operacion.Replace("÷", "/");

                // Manejar funciones trigonométricas
                operacion = ReemplazarFuncionTrigonometrica(operacion, "sin");
                operacion = ReemplazarFuncionTrigonometrica(operacion, "cos");
                operacion = ReemplazarFuncionTrigonometrica(operacion, "tan");

                // Manejar otras funciones
                operacion = operacion.Replace("log(", "Log10(");
                operacion = operacion.Replace("ln(", "Log(");
                operacion = ReemplazarFuncion(operacion, "exp", "Exp");
                // Manejar raíces n-ésimas y raíz cúbica
                operacion = Regex.Replace(operacion, @"(\d+)√\(([^)]+)\)", match =>
                {
                    string indice = match.Groups[1].Value;
                    string radicando = match.Groups[2].Value;
                    return $"Pow({radicando}, 1.0/{indice})";
                });
                operacion = Regex.Replace(operacion, @"3√\(([^)]+)\)", match =>
                {
                    string radicando = match.Groups[1].Value;
                    return $"Pow({radicando}, 1.0/3)";
                });
                operacion = ReemplazarFuncion(operacion, "√", "Sqrt");
                // Manejar potencias
                operacion = Regex.Replace(operacion, @"(\d+(\.\d+)?|\([^)]+\))\^(\d+(\.\d+)?|\([^)]+\))", match =>
                {
                    string base_ = match.Groups[1].Value;
                    string exponent = match.Groups[3].Value;
                    return $"Pow({base_}, {exponent})";
                });
                // Manejar factoriales
                operacion = ReemplazarFactorial(operacion);

                // Evaluar la expresión
                Expression exp = new Expression(operacion);
                var resultado = exp.Evaluate();

                // Redondear resultados muy cercanos a cero
                if (Math.Abs(Convert.ToDouble(resultado)) < 1e-10)
                {
                    resultado = 0;
                }

                Resultado.Text = resultado.ToString();
                Operacion.Text = operacionHistorial + " =";
                inicioNuevoNumero = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la operación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ReemplazarFuncionTrigonometrica(string operacion, string funcion)
        {
            return Regex.Replace(operacion, $@"{funcion}\(([^)]+)\)", match =>
            {
                string angulo = match.Groups[1].Value;
                return $"{char.ToUpper(funcion[0])}{funcion.Substring(1)}(({angulo}) * {Math.PI} / 180)";
            });
        }

        private string ReemplazarFuncion(string operacion, string funcionOriginal, string funcionNCalc)
        {
            return Regex.Replace(operacion, $@"{funcionOriginal}\(([^)]+)\)", $"{funcionNCalc}($1)");
        }

        private string ReemplazarFactorial(string operacion)
        {
            return Regex.Replace(operacion, @"(\d+)!", match =>
            {
                int num = int.Parse(match.Groups[1].Value);
                return Factorial(num).ToString();
            });
        }

        private int Factorial(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            else
                return num * Factorial(num - 1);
        }
        private void BorrarTodo_Click(object sender, EventArgs e)
        {
            Resultado.Text = "0";
            Operacion.Text = "";
            inicioNuevoNumero = true;
        }

        private void BorrarParcial_Click(object sender, EventArgs e)
        {
            Resultado.Text = "0";
            inicioNuevoNumero = true;
        }

        private void BorrarDigito_Click(object sender, EventArgs e)
        {
            if (Resultado.Text.Length > 1)
            {
                Resultado.Text = Resultado.Text.Substring(0, Resultado.Text.Length - 1);
            }
            else
            {
                Resultado.Text = "0";
                inicioNuevoNumero = true;
            }
        }
        private void Numero_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string numero = button.Text;

            if (inicioNuevoNumero)
            {
                string ultimoCaracter = Resultado.Text.Substring(Resultado.Text.Length - 1);
                if ("+-x÷%".Contains(ultimoCaracter))
                {
                    Resultado.Text += numero;
                    inicioNuevoNumero = false;
                }
                else
                {
                    Resultado.Text = numero;
                    inicioNuevoNumero = false;
                }
            }
            else
            {
                Resultado.Text += numero;
            }
        }
        private void Operacion_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string operador = button.Text;

            if (!inicioNuevoNumero)
            {
                Resultado.Text += operador;
                inicioNuevoNumero = true;
            }
            else
            {
                string ultimoCaracter = Resultado.Text.Substring(Resultado.Text.Length - 1);
                if ("+-x÷%".Contains(ultimoCaracter))
                {
                    Resultado.Text = Resultado.Text.Substring(0, Resultado.Text.Length - 1) + operador;
                }
                else
                {
                    Resultado.Text += operador;
                }
            }
        }
        private void FuncionCientifica_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string funcion = button.Text;
            string ultimoCaracter = Resultado.Text.Substring(Resultado.Text.Length - 1);

            if (Resultado.Text == "0")
            {
                Resultado.Text = "";
                inicioNuevoNumero = true;
            }

            switch (funcion)
            {
                case "sin":
                    if (Resultado.Text == "")
                    {
                        Resultado.Text = "sin(";
                    }
                    else if ("+-x÷%(".Contains(ultimoCaracter))
                    {
                        Resultado.Text += "sin(";
                    }
                    else
                    {
                        Resultado.Text += "xsin(";
                    }
                    inicioNuevoNumero = false;
                    break;
                case "cos":
                    if (Resultado.Text == "")
                    {
                        Resultado.Text = "cos(";
                    }
                    else if ("+-x÷%(".Contains(ultimoCaracter))
                    {
                        Resultado.Text += "cos(";
                    }
                    else
                    {
                        Resultado.Text += "xcos(";
                    }
                    inicioNuevoNumero = false;
                    break;
                case "tan":
                    if (Resultado.Text == "")
                    {
                        Resultado.Text = "tan(";
                    }
                    else if ("+-x÷%(".Contains(ultimoCaracter))
                    {
                        Resultado.Text += "tan(";
                    }
                    else
                    {
                        Resultado.Text += "xtan(";
                    }
                    inicioNuevoNumero = false;
                    break;
                case "log":
                    if (Resultado.Text == "")
                    {
                        Resultado.Text = "log(";
                    }
                    else if ("+-x÷%(".Contains(ultimoCaracter))
                    {
                        Resultado.Text += "log(";
                    }
                    else
                    {
                        Resultado.Text += "xlog(";
                    }
                    inicioNuevoNumero = false;
                    break;
                case "exp":
                    string buscarExp = Resultado.Text.Length >= 4 ? Resultado.Text.Substring(Resultado.Text.Length - 4) : Resultado.Text;
                    if (Resultado.Text == "")
                    {
                        Resultado.Text = "exp(";
                    }
                    else if (buscarExp == "exp(")
                    {
                        Resultado.Text += "0)";
                    }
                    else if ("+-x÷%(".Contains(ultimoCaracter))
                    {
                        Resultado.Text += "exp(";
                    }
                    else
                    {
                        Resultado.Text += "xexp(";
                    }
                    inicioNuevoNumero = false;
                    break;
                case "π":
                    if (Resultado.Text == "")
                    {
                        Resultado.Text = "π";
                    }
                    else if ("+-x÷%(".Contains(ultimoCaracter))
                    {
                        Resultado.Text += "π";
                    }
                    else
                    {
                        Resultado.Text = Resultado.Text + "x" + "π";
                    }
                    inicioNuevoNumero = false;
                    break;
                case "n!":
                    if (ultimoCaracter == "!")
                    {
                        Resultado.Text = Resultado.Text;
                    }
                    else if (Resultado.Text == "")
                    {
                        Resultado.Text = "0!";
                    }
                    else if ("+-x÷%(".Contains(ultimoCaracter))
                    {
                        MessageBox.Show($"Uso no válido de factorial '!'");
                    }
                    else if (Resultado.Text == "!")
                    {
                        Resultado.Text = Resultado.Text;
                    }
                    else
                    {
                        Resultado.Text += "!";
                    }
                    inicioNuevoNumero = false;
                    break;
                case "10^x":
                    if (Resultado.Text == "")
                    {
                        Resultado.Text = "10^(";
                    }
                    else if ("+-x÷%(".Contains(ultimoCaracter))
                    {
                        Resultado.Text += "10^(";
                    }
                    else
                    {
                        Resultado.Text = Resultado.Text + "x10^(";
                    }
                    inicioNuevoNumero = false;
                    break;
                case "3√x":
                    if (Resultado.Text == "")
                    {
                        Resultado.Text = "3√(";
                    }
                    else if ("+-x÷%(".Contains(ultimoCaracter))
                    {
                        Resultado.Text += "3√(";
                    }
                    else
                    {
                        Resultado.Text = Resultado.Text + "x3√(";
                    }
                    inicioNuevoNumero = false;
                    //Resultado.Text += "CubeRoot(";
                    break;
                case "y√x":
                    if (Resultado.Text == "")
                    {
                        Resultado.Text = "0√(";
                    }
                    /* else if ("+-x÷%(".Contains(ultimoCaracter))
                      {
                          Resultado.Text += "√(";
                      }*/
                    else
                    {
                        Resultado.Text = Resultado.Text + "√(";
                    }
                    inicioNuevoNumero = false;
                    //Resultado.Text += "Root(";
                    break;
                case "√":
                    if (Resultado.Text == "")
                    {
                        Resultado.Text = "√(";
                    }
                    else if ("+-x÷%(".Contains(ultimoCaracter))
                    {
                        Resultado.Text += "√(";
                    }
                    else
                    {
                        Resultado.Text = Resultado.Text + "x√(";
                    }
                    inicioNuevoNumero = false;
                    break;
                case "x^y":
                    if (Resultado.Text == "")
                    {
                        Resultado.Text = "0^(";
                    }
                    /*else if ("+-x÷%(".Contains(ultimoCaracter))
                    {
                        Resultado.Text = Resultado.Text + "^(";
                    }*/
                    else
                    {
                        Resultado.Text = Resultado.Text + "^(";
                    }
                    inicioNuevoNumero = false;
                    break;
                case "x^2":
                    if (Resultado.Text == "")
                    {
                        Resultado.Text = "0^(2)";
                    }
                    /*else if ("+-x÷%(".Contains(ultimoCaracter))
                    {
                        Resultado.Text = Resultado.Text + "^(2)";
                    }*/
                    else
                    {
                        Resultado.Text = Resultado.Text + "^(2)";
                    }
                    inicioNuevoNumero = false;
                    break;
                case "x^3":
                    if (Resultado.Text == "")
                    {
                        Resultado.Text = "0^(3)";
                    }
                    /*else if ("+-x÷%(".Contains(ultimoCaracter))
                    {
                        Resultado.Text = Resultado.Text + "^(3)";
                    }*/
                    else
                    {
                        Resultado.Text = Resultado.Text + "^(3)";
                    }
                    inicioNuevoNumero = false;
                    break;
                case "±":
                    if (Resultado.Text == "")
                    {
                        Resultado.Text = "0";
                    }
                    else if (Resultado.Text.StartsWith("-"))
                    {
                        Resultado.Text = Resultado.Text.Substring(1);
                    }
                    else
                    {
                        Resultado.Text = "-" + Resultado.Text;
                    }
                    inicioNuevoNumero = false;
                    break;
                case "(":
                    Resultado.Text += "(";
                    inicioNuevoNumero = false;
                    break;
                case ")":
                    Resultado.Text += ")";
                    inicioNuevoNumero = false;
                    break;
                case ".":
                    bool tienePunto = false;

                    for (int i = Resultado.Text.Length - 1; i >= 0; i--)
                    {
                        if ("+-x÷%()".Contains(Resultado.Text[i]))
                        {
                            break;
                        }
                        if (Resultado.Text[i] == '.')
                        {
                            tienePunto = true;
                            break;
                        }
                    }

                    if (ultimoCaracter != "π" && !tienePunto)
                    {
                        Resultado.Text += ".";
                    }
                    inicioNuevoNumero = false;
                    break;
                default:
                    Resultado.Text += funcion;
                    inicioNuevoNumero = false;
                    break;
            }
        }
    }
}