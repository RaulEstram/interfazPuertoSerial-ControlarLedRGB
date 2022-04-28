namespace flatUISerialPort.Forms
{
    partial class FormLeds
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenuLeds = new System.Windows.Forms.Panel();
            this.botonApagar = new System.Windows.Forms.Button();
            this.botonPrender = new System.Windows.Forms.Button();
            this.panelColorLed = new System.Windows.Forms.Panel();
            this.panelMenuColoresLed = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botonCyan = new System.Windows.Forms.Button();
            this.botonRosa = new System.Windows.Forms.Button();
            this.botonAzul = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botonAmarillo = new System.Windows.Forms.Button();
            this.botonRojo = new System.Windows.Forms.Button();
            this.botonBlanco = new System.Windows.Forms.Button();
            this.botonVerde = new System.Windows.Forms.Button();
            this.labelPuertoActual = new System.Windows.Forms.Label();
            this.panelMenuLeds.SuspendLayout();
            this.panelColorLed.SuspendLayout();
            this.panelMenuColoresLed.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuLeds
            // 
            this.panelMenuLeds.Controls.Add(this.botonApagar);
            this.panelMenuLeds.Controls.Add(this.botonPrender);
            this.panelMenuLeds.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenuLeds.Location = new System.Drawing.Point(0, 288);
            this.panelMenuLeds.Name = "panelMenuLeds";
            this.panelMenuLeds.Size = new System.Drawing.Size(604, 73);
            this.panelMenuLeds.TabIndex = 0;
            // 
            // botonApagar
            // 
            this.botonApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonApagar.FlatAppearance.BorderSize = 0;
            this.botonApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonApagar.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonApagar.Location = new System.Drawing.Point(137, 3);
            this.botonApagar.Name = "botonApagar";
            this.botonApagar.Size = new System.Drawing.Size(150, 50);
            this.botonApagar.TabIndex = 5;
            this.botonApagar.Text = "Apagar";
            this.botonApagar.UseVisualStyleBackColor = false;
            this.botonApagar.Click += new System.EventHandler(this.botonApagar_Click);
            // 
            // botonPrender
            // 
            this.botonPrender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonPrender.FlatAppearance.BorderSize = 0;
            this.botonPrender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPrender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPrender.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonPrender.Location = new System.Drawing.Point(293, 3);
            this.botonPrender.Name = "botonPrender";
            this.botonPrender.Size = new System.Drawing.Size(150, 50);
            this.botonPrender.TabIndex = 4;
            this.botonPrender.Text = "Prender";
            this.botonPrender.UseVisualStyleBackColor = false;
            this.botonPrender.Click += new System.EventHandler(this.botonPrender_Click);
            // 
            // panelColorLed
            // 
            this.panelColorLed.Controls.Add(this.labelPuertoActual);
            this.panelColorLed.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelColorLed.Location = new System.Drawing.Point(0, 0);
            this.panelColorLed.Name = "panelColorLed";
            this.panelColorLed.Size = new System.Drawing.Size(604, 28);
            this.panelColorLed.TabIndex = 1;
            // 
            // panelMenuColoresLed
            // 
            this.panelMenuColoresLed.Controls.Add(this.panel2);
            this.panelMenuColoresLed.Controls.Add(this.panel1);
            this.panelMenuColoresLed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuColoresLed.Location = new System.Drawing.Point(0, 28);
            this.panelMenuColoresLed.Name = "panelMenuColoresLed";
            this.panelMenuColoresLed.Size = new System.Drawing.Size(604, 260);
            this.panelMenuColoresLed.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.botonCyan);
            this.panel2.Controls.Add(this.botonRosa);
            this.panel2.Controls.Add(this.botonAzul);
            this.panel2.Location = new System.Drawing.Point(293, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(227, 257);
            this.panel2.TabIndex = 12;
            // 
            // botonCyan
            // 
            this.botonCyan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonCyan.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonCyan.FlatAppearance.BorderSize = 0;
            this.botonCyan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCyan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCyan.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonCyan.Location = new System.Drawing.Point(20, 120);
            this.botonCyan.Name = "botonCyan";
            this.botonCyan.Size = new System.Drawing.Size(187, 50);
            this.botonCyan.TabIndex = 9;
            this.botonCyan.Text = "Cyan";
            this.botonCyan.UseVisualStyleBackColor = false;
            this.botonCyan.Click += new System.EventHandler(this.botonCyan_Click);
            // 
            // botonRosa
            // 
            this.botonRosa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonRosa.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonRosa.FlatAppearance.BorderSize = 0;
            this.botonRosa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRosa.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonRosa.Location = new System.Drawing.Point(20, 70);
            this.botonRosa.Name = "botonRosa";
            this.botonRosa.Size = new System.Drawing.Size(187, 50);
            this.botonRosa.TabIndex = 10;
            this.botonRosa.Text = "Rosa";
            this.botonRosa.UseVisualStyleBackColor = false;
            this.botonRosa.Click += new System.EventHandler(this.botonRosa_Click);
            // 
            // botonAzul
            // 
            this.botonAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonAzul.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonAzul.FlatAppearance.BorderSize = 0;
            this.botonAzul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAzul.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonAzul.Location = new System.Drawing.Point(20, 20);
            this.botonAzul.Name = "botonAzul";
            this.botonAzul.Size = new System.Drawing.Size(187, 50);
            this.botonAzul.TabIndex = 8;
            this.botonAzul.Text = "Azul Marino";
            this.botonAzul.UseVisualStyleBackColor = false;
            this.botonAzul.Click += new System.EventHandler(this.botonAzul_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.botonAmarillo);
            this.panel1.Controls.Add(this.botonRojo);
            this.panel1.Controls.Add(this.botonBlanco);
            this.panel1.Controls.Add(this.botonVerde);
            this.panel1.Location = new System.Drawing.Point(60, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(227, 257);
            this.panel1.TabIndex = 11;
            // 
            // botonAmarillo
            // 
            this.botonAmarillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonAmarillo.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonAmarillo.FlatAppearance.BorderSize = 0;
            this.botonAmarillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAmarillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAmarillo.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonAmarillo.Location = new System.Drawing.Point(20, 170);
            this.botonAmarillo.Name = "botonAmarillo";
            this.botonAmarillo.Size = new System.Drawing.Size(187, 50);
            this.botonAmarillo.TabIndex = 5;
            this.botonAmarillo.Text = "Amarillo";
            this.botonAmarillo.UseVisualStyleBackColor = false;
            this.botonAmarillo.Click += new System.EventHandler(this.Amarillo_Click);
            // 
            // botonRojo
            // 
            this.botonRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonRojo.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonRojo.FlatAppearance.BorderSize = 0;
            this.botonRojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRojo.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonRojo.Location = new System.Drawing.Point(20, 120);
            this.botonRojo.Name = "botonRojo";
            this.botonRojo.Size = new System.Drawing.Size(187, 50);
            this.botonRojo.TabIndex = 6;
            this.botonRojo.Text = "Rojo";
            this.botonRojo.UseVisualStyleBackColor = false;
            this.botonRojo.Click += new System.EventHandler(this.botonRojo_Click);
            // 
            // botonBlanco
            // 
            this.botonBlanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonBlanco.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonBlanco.FlatAppearance.BorderSize = 0;
            this.botonBlanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBlanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBlanco.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonBlanco.Location = new System.Drawing.Point(20, 70);
            this.botonBlanco.Name = "botonBlanco";
            this.botonBlanco.Size = new System.Drawing.Size(187, 50);
            this.botonBlanco.TabIndex = 4;
            this.botonBlanco.Text = "Blanco";
            this.botonBlanco.UseVisualStyleBackColor = false;
            this.botonBlanco.Click += new System.EventHandler(this.botonBlanco_Click);
            // 
            // botonVerde
            // 
            this.botonVerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonVerde.Dock = System.Windows.Forms.DockStyle.Top;
            this.botonVerde.FlatAppearance.BorderSize = 0;
            this.botonVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVerde.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonVerde.Location = new System.Drawing.Point(20, 20);
            this.botonVerde.Name = "botonVerde";
            this.botonVerde.Size = new System.Drawing.Size(187, 50);
            this.botonVerde.TabIndex = 7;
            this.botonVerde.Text = "Verde";
            this.botonVerde.UseVisualStyleBackColor = false;
            this.botonVerde.Click += new System.EventHandler(this.botonVerde_Click);
            // 
            // labelPuertoActual
            // 
            this.labelPuertoActual.AutoSize = true;
            this.labelPuertoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuertoActual.ForeColor = System.Drawing.Color.Black;
            this.labelPuertoActual.Location = new System.Drawing.Point(133, 5);
            this.labelPuertoActual.Name = "labelPuertoActual";
            this.labelPuertoActual.Size = new System.Drawing.Size(307, 20);
            this.labelPuertoActual.TabIndex = 0;
            this.labelPuertoActual.Text = "Puerto conectado actual: No seleccionado";
            // 
            // FormLeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 361);
            this.Controls.Add(this.panelMenuColoresLed);
            this.Controls.Add(this.panelColorLed);
            this.Controls.Add(this.panelMenuLeds);
            this.Name = "FormLeds";
            this.Text = "FormLeds";
            this.Load += new System.EventHandler(this.FormLeds_Load);
            this.panelMenuLeds.ResumeLayout(false);
            this.panelColorLed.ResumeLayout(false);
            this.panelColorLed.PerformLayout();
            this.panelMenuColoresLed.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLeds;
        private System.Windows.Forms.Panel panelColorLed;
        private System.Windows.Forms.Panel panelMenuColoresLed;
        private System.Windows.Forms.Button botonApagar;
        private System.Windows.Forms.Button botonPrender;
        private System.Windows.Forms.Button botonRosa;
        private System.Windows.Forms.Button botonCyan;
        private System.Windows.Forms.Button botonAzul;
        private System.Windows.Forms.Button botonVerde;
        private System.Windows.Forms.Button botonRojo;
        private System.Windows.Forms.Button botonAmarillo;
        private System.Windows.Forms.Button botonBlanco;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPuertoActual;
    }
}