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
    public partial class FormSerialPort : Form
    {
        public static FormSerialPort instance;
        public static string puertoSerial;


        public FormSerialPort()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            CenterToScreen();
            instance = this;
        }

        private void FormSerialPort_Load(object sender, EventArgs e)
        {
            cargarPuertosSeriales();
            opcionesporDefecto();
            if (Form1.conectado)
            {
                cargarHistorial();
            }
        }

        public void cargarPuertosSeriales()
        {
            string[] listaPuetosSeriales = System.IO.Ports.SerialPort.GetPortNames();
            listaPuertosSeriales.DataSource = listaPuetosSeriales;
        }

        public void opcionesporDefecto()
        {
            botonConectarPuertoSerial.Enabled = true;
            botonDesconectarPuertoSerial.Enabled = false;
            labelPuertoSerialSeleccionado.Text = "No Conectado";
        }

        public void cargarHistorial() {
            botonConectarPuertoSerial.Enabled = Form1.estadoConectado;
            botonDesconectarPuertoSerial.Enabled = Form1.estadoDesconectado;
            labelPuertoSerialSeleccionado.Text = Form1.puertoSerialConectado;
        }

        private void botonActualizarPuertosSeriales_Click(object sender, EventArgs e)
        {
            cargarPuertosSeriales();
        }

        private void botonConectarPuertoSerial_Click(object sender, EventArgs e)
        {
            puertoSerial = listaPuertosSeriales.SelectedItem.ToString();
            labelPuertoSerialSeleccionado.Text = puertoSerial;
            if (!Form1.serialPortMain.IsOpen)
            {
                try
                {
                    Form1.serialPortMain.PortName = puertoSerial;
                    Form1.serialPortMain.Open();
                    botonConectarPuertoSerial.Enabled = false;
                    botonDesconectarPuertoSerial.Enabled = true;

                    Form1.estadoConectado = false;
                    Form1.estadoDesconectado = true;
                    Form1.puertoSerialConectado = puertoSerial;
                    Form1.conectado = true;
                }
                catch
                {
                    MessageBox.Show("Error al conectarse al puerto serial: " + labelPuertoSerialSeleccionado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cargarPuertosSeriales();
                    opcionesporDefecto();
                }
            }

        }

        private void botonDesconectarPuertoSerial_Click(object sender, EventArgs e)
        {
            if (Form1.serialPortMain.IsOpen)
            {
                Form1.serialPortMain.Close();
                opcionesporDefecto();
                Form1.conectado = false;
                Form1.puertoSerialConectado = "No Esta conectado";
            }
        }

 
    }
}
