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
            loadTheme();
            cargarDatos();

            if (Form1.ledPrendido && Form1.conectado)
            {
                cargarConfiguracionPrendido();
            }
            else {
                cargarConfiguracionApagado();
            }
            

        }

        public void cargarDatos() {
            labelPuertoActual.Text = "Puerto Serial Conectado: " + Form1.puertoSerialConectado;
        }
        public void cargarConfiguracionApagado() {
            botonPrender.Enabled = true;
            botonApagar.Enabled=false;  
            botonAzul.Enabled=false;
            botonBlanco.Enabled=false;
            botonCyan.Enabled=false;
            botonRojo.Enabled=false;
            botonRosa.Enabled=false;
            botonVerde.Enabled=false;
            botonAmarillo.Enabled=false;
            Form1.ledPrendido = false;
        }

        public void cargarConfiguracionPrendido()
        {
            botonPrender.Enabled = false;
            botonApagar.Enabled = true;
            botonAzul.Enabled = true;
            botonBlanco.Enabled = true;
            botonCyan.Enabled = true;
            botonRojo.Enabled = true;
            botonRosa.Enabled = true;
            botonVerde.Enabled = true;
            botonAmarillo.Enabled = true;
            Form1.ledPrendido=true;
        }

        private void botonVerde_Click(object sender, EventArgs e)
        {
            if (Form1.serialPortMain.IsOpen)
            {
                Form1.serialPortMain.Write("A");
            }
        }

        private void botonBlanco_Click(object sender, EventArgs e)
        {
            if (Form1.serialPortMain.IsOpen)
            {
                Form1.serialPortMain.Write("B");
            }
        }

        private void botonRojo_Click(object sender, EventArgs e)
        {
            if (Form1.serialPortMain.IsOpen)
            {
                Form1.serialPortMain.Write("C");
            }
        }

        private void Amarillo_Click(object sender, EventArgs e)
        {
            if (Form1.serialPortMain.IsOpen)
            {
                Form1.serialPortMain.Write("D");
            }
        }

        private void botonAzul_Click(object sender, EventArgs e)
        {
            if (Form1.serialPortMain.IsOpen)
            {
                Form1.serialPortMain.Write("E");
            }
        }

        private void botonRosa_Click(object sender, EventArgs e)
        {
            if (Form1.serialPortMain.IsOpen)
            {
                Form1.serialPortMain.Write("F");
            }
        }

        private void botonCyan_Click(object sender, EventArgs e)
        {
            if (Form1.serialPortMain.IsOpen)
            {
                Form1.serialPortMain.Write("G");
            }
        }

        private void botonApagar_Click(object sender, EventArgs e)
        {
            cargarConfiguracionApagado();
            if (Form1.serialPortMain.IsOpen)
            {
                Form1.serialPortMain.Write("H");
            }
        }

        private void botonPrender_Click(object sender, EventArgs e)
        {
            if (Form1.conectado)
            {
                cargarConfiguracionPrendido();
                if (Form1.serialPortMain.IsOpen)
                {
                    Form1.serialPortMain.Write("I");
                }
            }
        }

        // metodos theme
        private void loadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.primatyColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.secondColor;
                }
            }

        }
    }
}
