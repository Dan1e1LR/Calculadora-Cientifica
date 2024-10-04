using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCientifica
{
    public partial class FormActualizacion : Form
    {
        public FormActualizacion()
        {
            InitializeComponent();
        }
        public void ActualizarProgreso(int porcentaje)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<int>(ActualizarProgreso), porcentaje);
                return;
            }
            progressBar1.Value = porcentaje;
            label1.Text = $"Descargando actualización: {porcentaje}%";
        }
    }
}
