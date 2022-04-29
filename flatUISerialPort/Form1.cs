using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            closeChild.Visible = false;
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Form1_Load(object sender, EventArgs e)
        {

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
            openChildForm(new Forms.Otros(), sender);
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
                    ThemeColor.primatyColor = color;
                    ThemeColor.secondColor = ThemeColor.cambiarBrilloColor(color, -0.3);
                    closeChild.Visible = true;
                }
            }
        }

        private void desactivarBoton() {
        foreach(Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button)) {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
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
            panelDesktopPanel.Controls.Add(childForm);
            panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitulo.Text = childForm.Text;
        }

        private void closeChild_Click(object sender, EventArgs e)
        {
            if (activeForm != null) {
                activeForm.Close();
            }
            Reset();
        }

        private void Reset() {
            desactivarBoton();
            labelTitulo.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0,150,136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            closeChild.Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
