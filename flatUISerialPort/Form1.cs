using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flatUISerialPort
{
    public partial class Form1 : Form
    {
        // variables para form del serial port
        public static Form1 instance;
        public static System.IO.Ports.SerialPort serialPortMain;
        public static bool estadoConectado;
        public static bool estadoDesconectado;
        public static string puertoSerialConectado = "No Esta conectado";
        public static bool conectado = false;

        // vairables para el form del control del led

        public static bool ledPrendido;

        // fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            instance = this;
            serialPortMain = serialPortHome;
        }

        // metodos click botones

        private void botonMenuSerialPort_Click(object sender, EventArgs e)
        {
            Forms.FormSerialPort child = new Forms.FormSerialPort();
            openChildForm(child, sender);
        }

        private void butonMenuLed_Click(object sender, EventArgs e)
        {
            openChildForm(new Forms.FormLeds(), sender);
        }

        private void botonMenuOtros_Click(object sender, EventArgs e)
        {
            activarBoton(sender);
        }

        // metodos Colores e Interfaz

        private Color selectThemeColor() { 
            int index = random.Next(ThemeColor.colors.Count);
            while (tempIndex == index) {
                index = random.Next(ThemeColor.colors.Count);
            }
            tempIndex = index;
            string color = ThemeColor.colors[index];
            return ColorTranslator.FromHtml(color);
        }

        private void activarBoton(Object btnSender) {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    desactivarBoton();
                    Color color = selectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.cambiarBrilloColor(color, -0.3 );
                }
            }
        }

        private void desactivarBoton() {
        foreach(Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button)) {
                    previousBtn.BackColor = Color.FromArgb(144, 12, 63);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        
        }

        private void openChildForm(Form childForm, object btnSender) {

            if (activeForm != null)
            {
                activeForm.Close();
            }
            activarBoton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitulo.Text = childForm.Text;
        }


        
    }
}
