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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeChild = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panelMenu.Size = new System.Drawing.Size(180, 511);
            this.panelMenu.TabIndex = 0;
            // 
            // botonMenuOtros
            // 
            this.botonMenuOtros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
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
            this.butonMenuLed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
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
            this.botonMenuSerialPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
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
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
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
            this.panelTitleBar.Controls.Add(this.minimizar);
            this.panelTitleBar.Controls.Add(this.maximizar);
            this.panelTitleBar.Controls.Add(this.exit);
            this.panelTitleBar.Controls.Add(this.closeChild);
            this.panelTitleBar.Controls.Add(this.labelTitulo);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(180, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(654, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown_1);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Copperplate Gothic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(64, 28);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(95, 26);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Controls.Add(this.pictureBox2);
            this.panelDesktopPanel.Controls.Add(this.pictureBox1);
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(180, 80);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(654, 431);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::flatUISerialPort.Properties.Resources.waifuhome;
            this.pictureBox1.Location = new System.Drawing.Point(793, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 307);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // closeChild
            // 
            this.closeChild.BackgroundImage = global::flatUISerialPort.Properties.Resources.exit;
            this.closeChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeChild.FlatAppearance.BorderSize = 0;
            this.closeChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeChild.Location = new System.Drawing.Point(15, 28);
            this.closeChild.Name = "closeChild";
            this.closeChild.Size = new System.Drawing.Size(31, 26);
            this.closeChild.TabIndex = 0;
            this.closeChild.UseVisualStyleBackColor = true;
            this.closeChild.Click += new System.EventHandler(this.closeChild_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(621, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 30);
            this.exit.TabIndex = 1;
            this.exit.Text = "O";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.FlatAppearance.BorderSize = 0;
            this.maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximizar.ForeColor = System.Drawing.Color.White;
            this.maximizar.Location = new System.Drawing.Point(585, 3);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(30, 30);
            this.maximizar.TabIndex = 2;
            this.maximizar.Text = "O";
            this.maximizar.UseVisualStyleBackColor = true;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click_1);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.FlatAppearance.BorderSize = 0;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizar.ForeColor = System.Drawing.Color.White;
            this.minimizar.Location = new System.Drawing.Point(549, 3);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(30, 30);
            this.minimizar.TabIndex = 3;
            this.minimizar.Text = "O";
            this.minimizar.UseVisualStyleBackColor = true;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::flatUISerialPort.Properties.Resources.waifuhome;
            this.pictureBox2.Location = new System.Drawing.Point(445, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 371);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 475);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button closeChild;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Button maximizar;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

