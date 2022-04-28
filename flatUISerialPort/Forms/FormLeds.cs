using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flatUISerialPort.Forms
{
    public partial class FormLeds : Form
    {
        public FormLeds()
        {
            InitializeComponent();
        }

        private void FormLeds_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        public void cargarDatos() {
            labelPuertoActual.Text = "Puerto Serial Conectado: " + Form1.puertoSerialConectado;
        }
    }
}
