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
    public partial class Otros : Form
    {
        public Otros()
        {
            InitializeComponent();
        }

        private void Otros_Load(object sender, EventArgs e)
        {
            loadTheme();
        }

        private void botonGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RaulEstram/interfazPuertoSerial-ControlarLedRGB");
        }



        // metodo theme
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
