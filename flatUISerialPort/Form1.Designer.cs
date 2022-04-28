namespace flatUISerialPort
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.botonMenuOtros = new System.Windows.Forms.Button();
            this.butonMenuLed = new System.Windows.Forms.Button();
            this.botonMenuSerialPort = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.titulo = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.serialPortHome = new System.IO.Ports.SerialPort(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.botonMenuOtros);
            this.panelMenu.Controls.Add(this.butonMenuLed);
            this.panelMenu.Controls.Add(this.botonMenuSerialPort);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // botonMenuOtros
            // 
            this.botonMenuOtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.botonMenuOtros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonMenuOtros.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonMenuOtros.FlatAppearance.BorderSize = 0;
            this.botonMenuOtros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonMenuOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMenuOtros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonMenuOtros.Location = new System.Drawing.Point(0, 200);
            this.botonMenuOtros.Name = "botonMenuOtros";
            this.botonMenuOtros.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.botonMenuOtros.Size = new System.Drawing.Size(180, 60);
            this.botonMenuOtros.TabIndex = 3;
            this.botonMenuOtros.Text = "Otros";
            this.botonMenuOtros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botonMenuOtros.UseVisualStyleBackColor = false;
            this.botonMenuOtros.Click += new System.EventHandler(this.botonMenuOtros_Click);
            // 
            // butonMenuLed
            // 
            this.butonMenuLed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.butonMenuLed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butonMenuLed.Dock = System.Windows.Forms.DockStyle.Top;
            this.butonMenuLed.FlatAppearance.BorderSize = 0;
            this.butonMenuLed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonMenuLed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonMenuLed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butonMenuLed.Location = new System.Drawing.Point(0, 140);
            this.butonMenuLed.Name = "butonMenuLed";
            this.butonMenuLed.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.butonMenuLed.Size = new System.Drawing.Size(180, 60);
            this.butonMenuLed.TabIndex = 2;
            this.butonMenuLed.Text = "Controlar Led";
            this.butonMenuLed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.butonMenuLed.UseVisualStyleBackColor = false;
            this.butonMenuLed.Click += new System.EventHandler(this.butonMenuLed_Click);
            // 
            // botonMenuSerialPort
            // 
            this.botonMenuSerialPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(12)))), ((int)(((byte)(63)))));
            this.botonMenuSerialPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonMenuSerialPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonMenuSerialPort.FlatAppearance.BorderSize = 0;
            this.botonMenuSerialPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonMenuSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMenuSerialPort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonMenuSerialPort.Location = new System.Drawing.Point(0, 80);
            this.botonMenuSerialPort.Name = "botonMenuSerialPort";
            this.botonMenuSerialPort.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.botonMenuSerialPort.Size = new System.Drawing.Size(180, 60);
            this.botonMenuSerialPort.TabIndex = 1;
            this.botonMenuSerialPort.Text = "Puertos Seriales";
            this.botonMenuSerialPort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.botonMenuSerialPort.UseVisualStyleBackColor = false;
            this.botonMenuSerialPort.Click += new System.EventHandler(this.botonMenuSerialPort_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(16)))), ((int)(((byte)(45)))));
            this.panelLogo.Controls.Add(this.titulo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(180, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(21, 33);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(144, 20);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Microcontroladores";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.labelTitulo);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(180, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(620, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(243, 27);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(95, 26);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(180, 80);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(620, 370);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button botonMenuSerialPort;
        private System.Windows.Forms.Button botonMenuOtros;
        private System.Windows.Forms.Button butonMenuLed;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.IO.Ports.SerialPort serialPortHome;
    }
}

