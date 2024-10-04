namespace CalculadoraCientifica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pi = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.borrarParcial = new System.Windows.Forms.Button();
            this.borrarTodo = new System.Windows.Forms.Button();
            this.borrarDigito = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.calcular = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.masMenos = new System.Windows.Forms.Button();
            this.Operacion = new System.Windows.Forms.TextBox();
            this.nfactorial = new System.Windows.Forms.Button();
            this.xElevadoy = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.xElevadotres = new System.Windows.Forms.Button();
            this.xElevadodos = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.yRaizx = new System.Windows.Forms.Button();
            this.tresRaizx = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.porcentaje = new System.Windows.Forms.Button();
            this.diezElevadox = new System.Windows.Forms.Button();
            this.parentesisAbre = new System.Windows.Forms.Button();
            this.parentesisCierre = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pi
            // 
            this.pi.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pi.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.pi.Image = ((System.Drawing.Image)(resources.GetObject("pi.Image")));
            this.pi.Location = new System.Drawing.Point(3, 186);
            this.pi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(79, 38);
            this.pi.TabIndex = 1;
            this.pi.Text = "π";
            this.pi.UseVisualStyleBackColor = true;
            this.pi.Click += new System.EventHandler(this.FuncionCientifica_Click);
            // 
            // Resultado
            // 
            this.Resultado.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(9, 49);
            this.Resultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Resultado.Name = "Resultado";
            this.Resultado.ReadOnly = true;
            this.Resultado.Size = new System.Drawing.Size(405, 55);
            this.Resultado.TabIndex = 2;
            this.Resultado.Text = "0";
            this.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // borrarParcial
            // 
            this.borrarParcial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarParcial.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.borrarParcial.Location = new System.Drawing.Point(170, 143);
            this.borrarParcial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.borrarParcial.Name = "borrarParcial";
            this.borrarParcial.Size = new System.Drawing.Size(79, 38);
            this.borrarParcial.TabIndex = 3;
            this.borrarParcial.Text = "CE";
            this.borrarParcial.UseVisualStyleBackColor = true;
            this.borrarParcial.Click += new System.EventHandler(this.BorrarParcial_Click);
            // 
            // borrarTodo
            // 
            this.borrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarTodo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.borrarTodo.Location = new System.Drawing.Point(253, 143);
            this.borrarTodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.borrarTodo.Name = "borrarTodo";
            this.borrarTodo.Size = new System.Drawing.Size(79, 38);
            this.borrarTodo.TabIndex = 4;
            this.borrarTodo.Text = "C";
            this.borrarTodo.UseVisualStyleBackColor = true;
            this.borrarTodo.Click += new System.EventHandler(this.BorrarTodo_Click);
            // 
            // borrarDigito
            // 
            this.borrarDigito.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrarDigito.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.borrarDigito.Image = ((System.Drawing.Image)(resources.GetObject("borrarDigito.Image")));
            this.borrarDigito.Location = new System.Drawing.Point(336, 143);
            this.borrarDigito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.borrarDigito.Name = "borrarDigito";
            this.borrarDigito.Size = new System.Drawing.Size(79, 38);
            this.borrarDigito.TabIndex = 5;
            this.borrarDigito.UseVisualStyleBackColor = true;
            this.borrarDigito.Click += new System.EventHandler(this.BorrarDigito_Click);
            // 
            // num7
            // 
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num7.Location = new System.Drawing.Point(3, 315);
            this.num7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(79, 38);
            this.num7.TabIndex = 6;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.Numero_Click);
            // 
            // num8
            // 
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num8.Location = new System.Drawing.Point(86, 315);
            this.num8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(79, 38);
            this.num8.TabIndex = 7;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.Numero_Click);
            // 
            // num9
            // 
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num9.Location = new System.Drawing.Point(170, 315);
            this.num9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(79, 38);
            this.num9.TabIndex = 8;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.Numero_Click);
            // 
            // multiplicacion
            // 
            this.multiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.multiplicacion.Location = new System.Drawing.Point(253, 357);
            this.multiplicacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(79, 38);
            this.multiplicacion.TabIndex = 9;
            this.multiplicacion.Text = "x";
            this.multiplicacion.UseVisualStyleBackColor = true;
            this.multiplicacion.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // num4
            // 
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num4.Location = new System.Drawing.Point(3, 358);
            this.num4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(79, 38);
            this.num4.TabIndex = 10;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.Numero_Click);
            // 
            // num5
            // 
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num5.Location = new System.Drawing.Point(86, 358);
            this.num5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(79, 38);
            this.num5.TabIndex = 11;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.Numero_Click);
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num3.Location = new System.Drawing.Point(170, 401);
            this.num3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(79, 38);
            this.num3.TabIndex = 12;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.Numero_Click);
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num1.Location = new System.Drawing.Point(3, 401);
            this.num1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(79, 38);
            this.num1.TabIndex = 12;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.Numero_Click);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num2.Location = new System.Drawing.Point(86, 401);
            this.num2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(79, 38);
            this.num2.TabIndex = 13;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.Numero_Click);
            // 
            // num6
            // 
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num6.Location = new System.Drawing.Point(170, 357);
            this.num6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(79, 38);
            this.num6.TabIndex = 14;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.Numero_Click);
            // 
            // num0
            // 
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.num0.Location = new System.Drawing.Point(3, 444);
            this.num0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(79, 38);
            this.num0.TabIndex = 15;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.Numero_Click);
            // 
            // punto
            // 
            this.punto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.punto.Location = new System.Drawing.Point(86, 444);
            this.punto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(79, 38);
            this.punto.TabIndex = 16;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = true;
            this.punto.Click += new System.EventHandler(this.FuncionCientifica_Click);
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.SystemColors.Highlight;
            this.calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular.ForeColor = System.Drawing.SystemColors.Window;
            this.calcular.Location = new System.Drawing.Point(336, 444);
            this.calcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(79, 38);
            this.calcular.TabIndex = 17;
            this.calcular.Text = "=";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // suma
            // 
            this.suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.suma.Location = new System.Drawing.Point(253, 401);
            this.suma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(79, 38);
            this.suma.TabIndex = 18;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // resta
            // 
            this.resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resta.Location = new System.Drawing.Point(336, 401);
            this.resta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(79, 38);
            this.resta.TabIndex = 19;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // masMenos
            // 
            this.masMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masMenos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.masMenos.Location = new System.Drawing.Point(170, 444);
            this.masMenos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masMenos.Name = "masMenos";
            this.masMenos.Size = new System.Drawing.Size(79, 38);
            this.masMenos.TabIndex = 20;
            this.masMenos.Text = "±";
            this.masMenos.UseVisualStyleBackColor = true;
            this.masMenos.Click += new System.EventHandler(this.FuncionCientifica_Click);
            // 
            // Operacion
            // 
            this.Operacion.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Operacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Operacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operacion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Operacion.Location = new System.Drawing.Point(9, 10);
            this.Operacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Operacion.Name = "Operacion";
            this.Operacion.ReadOnly = true;
            this.Operacion.Size = new System.Drawing.Size(405, 34);
            this.Operacion.TabIndex = 21;
            this.Operacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nfactorial
            // 
            this.nfactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nfactorial.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nfactorial.Location = new System.Drawing.Point(336, 186);
            this.nfactorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nfactorial.Name = "nfactorial";
            this.nfactorial.Size = new System.Drawing.Size(79, 38);
            this.nfactorial.TabIndex = 24;
            this.nfactorial.Text = "n!";
            this.nfactorial.UseVisualStyleBackColor = true;
            this.nfactorial.Click += new System.EventHandler(this.FuncionCientifica_Click);
            // 
            // xElevadoy
            // 
            this.xElevadoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xElevadoy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.xElevadoy.Location = new System.Drawing.Point(3, 272);
            this.xElevadoy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xElevadoy.Name = "xElevadoy";
            this.xElevadoy.Size = new System.Drawing.Size(79, 38);
            this.xElevadoy.TabIndex = 23;
            this.xElevadoy.Text = "x^y";
            this.xElevadoy.UseVisualStyleBackColor = true;
            this.xElevadoy.Click += new System.EventHandler(this.FuncionCientifica_Click);
            // 
            // exp
            // 
            this.exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exp.Location = new System.Drawing.Point(253, 444);
            this.exp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(79, 38);
            this.exp.TabIndex = 22;
            this.exp.Text = "exp";
            this.exp.UseVisualStyleBackColor = true;
            this.exp.Click += new System.EventHandler(this.FuncionCientifica_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.division.Location = new System.Drawing.Point(336, 357);
            this.division.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(79, 38);
            this.division.TabIndex = 25;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // log
            // 
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.log.Location = new System.Drawing.Point(253, 272);
            this.log.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(79, 38);
            this.log.TabIndex = 26;
            this.log.Text = "log";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.FuncionCientifica_Click);
            // 
            // xElevadotres
            // 
            this.xElevadotres.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xElevadotres.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.xElevadotres.Location = new System.Drawing.Point(170, 272);
            this.xElevadotres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xElevadotres.Name = "xElevadotres";
            this.xElevadotres.Size = new System.Drawing.Size(79, 38);
            this.xElevadotres.TabIndex = 27;
            this.xElevadotres.Text = "x^3";
            this.xElevadotres.UseVisualStyleBackColor = true;
            this.xElevadotres.Click += new System.EventHandler(this.FuncionCientifica_Click);
            // 
            // xElevadodos
            // 
            this.xElevadodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xElevadodos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.xElevadodos.Location = new System.Drawing.Point(86, 272);
            this.xElevadodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.xElevadodos.Name = "xElevadodos";
            this.xElevadodos.Size = new System.Drawing.Size(79, 38);
            this.xElevadodos.TabIndex = 28;
            this.xElevadodos.Text = "x^2";
            this.xElevadodos.UseVisualStyleBackColor = true;
            this.xElevadodos.Click += new System.EventHandler(this.FuncionCientifica_Click);
            // 
            // tan
            // 
            this.tan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tan.Location = new System.Drawing.Point(253, 186);
            this.tan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(79, 38);
            this.tan.TabIndex = 29;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.FuncionCientifica_Click);
            // 
            // cos
            // 
            this.cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cos.Location = new System.Drawing.Point(170, 186);
            this.cos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(79, 38);
            this.cos.TabIndex = 30;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.FuncionCientifica_Click);
            // 
            // raiz
            // 
            this.raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raiz.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.raiz.Location = new System.Drawing.Point(253, 229);
            this.raiz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(79, 38);
            this.raiz.TabIndex = 31;
            this.raiz.Text = "√";
            this.raiz.UseVisualStyleBackColor = true;
            this.raiz.Click += new System.EventHandler(this.FuncionCientifica_Click);
            // 
            // yRaizx
            // 
            this.yRaizx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yRaizx.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.yRaizx.Location = new System.Drawing.Point(170, 229);
            this.yRaizx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.yRaizx.Name = "yRaizx";
            this.yRaizx.Size = new System.Drawing.Size(79, 38);
            this.yRaizx.TabIndex = 32;
            this.yRaizx.Text = "y√x";
            this.yRaizx.UseVisualStyleBackColor = true;
            this.yRaizx.Click += new System.EventHandler(this.FuncionCientifica_Click);
            // 
            // tresRaizx
            // 
            this.tresRaizx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tresRaizx.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tresRaizx.Location = new System.Drawing.Point(86, 229);
            this.tresRaizx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tresRaizx.Name = "tresRaizx";
            this.tresRaizx.Size = new System.Drawing.Size(79, 38);
            this.tresRaizx.TabIndex = 33;
            this.tresRaizx.Text = "3√x";
            this.tresRaizx.UseVisualStyleBackColor = true;
            this.tresRaizx.Click += new System.EventHandler(this.FuncionCientifica_Click);
            // 
            // sin
            // 
            this.sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sin.Location = new System.Drawing.Point(86, 186);
            this.sin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(79, 38);
            this.sin.TabIndex = 34;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.FuncionCientifica_Click);
            // 
            // porcentaje
            // 
            this.porcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentaje.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.porcentaje.Location = new System.Drawing.Point(336, 272);
            this.porcentaje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.porcentaje.Name = "porcentaje";
            this.porcentaje.Size = new System.Drawing.Size(79, 38);
            this.porcentaje.TabIndex = 35;
            this.porcentaje.Text = "%";
            this.porcentaje.UseVisualStyleBackColor = true;
            this.porcentaje.Click += new System.EventHandler(this.Operacion_Click);
            // 
            // diezElevadox
            // 
            this.diezElevadox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diezElevadox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.diezElevadox.Location = new System.Drawing.Point(3, 229);
            this.diezElevadox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diezElevadox.Name = "diezElevadox";
            this.diezElevadox.Size = new System.Drawing.Size(79, 38);
            this.diezElevadox.TabIndex = 36;
            this.diezElevadox.Text = "10^x";
            this.diezElevadox.UseVisualStyleBackColor = true;
            this.diezElevadox.Click += new System.EventHandler(this.FuncionCientifica_Click);
            // 
            // parentesisAbre
            // 
            this.parentesisAbre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentesisAbre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.parentesisAbre.Location = new System.Drawing.Point(253, 315);
            this.parentesisAbre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.parentesisAbre.Name = "parentesisAbre";
            this.parentesisAbre.Size = new System.Drawing.Size(79, 38);
            this.parentesisAbre.TabIndex = 37;
            this.parentesisAbre.Text = "(";
            this.parentesisAbre.UseVisualStyleBackColor = true;
            this.parentesisAbre.Click += new System.EventHandler(this.FuncionCientifica_Click);
            // 
            // parentesisCierre
            // 
            this.parentesisCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentesisCierre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.parentesisCierre.Location = new System.Drawing.Point(336, 315);
            this.parentesisCierre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.parentesisCierre.Name = "parentesisCierre";
            this.parentesisCierre.Size = new System.Drawing.Size(79, 38);
            this.parentesisCierre.TabIndex = 38;
            this.parentesisCierre.Text = ")";
            this.parentesisCierre.UseVisualStyleBackColor = true;
            this.parentesisCierre.Click += new System.EventHandler(this.FuncionCientifica_Click);
            // 
            // actualizar
            // 
            this.actualizar.BackColor = System.Drawing.SystemColors.Info;
            this.actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.actualizar.Location = new System.Drawing.Point(3, 142);
            this.actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(162, 38);
            this.actualizar.TabIndex = 39;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = false;
            this.actualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(64, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Hay una actualizacion disponible!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(419, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.parentesisCierre);
            this.Controls.Add(this.parentesisAbre);
            this.Controls.Add(this.diezElevadox);
            this.Controls.Add(this.porcentaje);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.tresRaizx);
            this.Controls.Add(this.yRaizx);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.xElevadodos);
            this.Controls.Add(this.xElevadotres);
            this.Controls.Add(this.log);
            this.Controls.Add(this.division);
            this.Controls.Add(this.nfactorial);
            this.Controls.Add(this.xElevadoy);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.Operacion);
            this.Controls.Add(this.masMenos);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.borrarDigito);
            this.Controls.Add(this.borrarTodo);
            this.Controls.Add(this.borrarParcial);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.pi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Calculadora Científica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pi;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Button borrarParcial;
        private System.Windows.Forms.Button borrarTodo;
        private System.Windows.Forms.Button borrarDigito;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button punto;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button masMenos;
        private System.Windows.Forms.TextBox Operacion;
        private System.Windows.Forms.Button nfactorial;
        private System.Windows.Forms.Button xElevadoy;
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button xElevadotres;
        private System.Windows.Forms.Button xElevadodos;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button raiz;
        private System.Windows.Forms.Button yRaizx;
        private System.Windows.Forms.Button tresRaizx;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button porcentaje;
        private System.Windows.Forms.Button diezElevadox;
        private System.Windows.Forms.Button parentesisAbre;
        private System.Windows.Forms.Button parentesisCierre;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.Label label1;
    }
}