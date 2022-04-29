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
            this.labelPuertoActual = new System.Windows.Forms.Label();
            this.botonCyan = new System.Windows.Forms.Button();
            this.botonRosa = new System.Windows.Forms.Button();
            this.botonAzul = new System.Windows.Forms.Button();
            this.botonAmarillo = new System.Windows.Forms.Button();
            this.botonRojo = new System.Windows.Forms.Button();
            this.botonBlanco = new System.Windows.Forms.Button();
            this.botonVerde = new System.Windows.Forms.Button();
            this.botonPrender = new System.Windows.Forms.Button();
            this.botonApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPuertoActual
            // 
            this.labelPuertoActual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPuertoActual.AutoSize = true;
            this.labelPuertoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuertoActual.ForeColor = System.Drawing.Color.Black;
            this.labelPuertoActual.Location = new System.Drawing.Point(154, 9);
            this.labelPuertoActual.Name = "labelPuertoActual";
            this.labelPuertoActual.Size = new System.Drawing.Size(307, 20);
            this.labelPuertoActual.TabIndex = 0;
            this.labelPuertoActual.Text = "Puerto conectado actual: No seleccionado";
            // 
            // botonCyan
            // 
            this.botonCyan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonCyan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonCyan.FlatAppearance.BorderSize = 0;
            this.botonCyan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCyan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCyan.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonCyan.Location = new System.Drawing.Point(99, 210);
            this.botonCyan.Name = "botonCyan";
            this.botonCyan.Size = new System.Drawing.Size(187, 50);
            this.botonCyan.TabIndex = 9;
            this.botonCyan.Text = "Cyan";
            this.botonCyan.UseVisualStyleBackColor = false;
            this.botonCyan.Click += new System.EventHandler(this.botonCyan_Click);
            // 
            // botonRosa
            // 
            this.botonRosa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonRosa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonRosa.FlatAppearance.BorderSize = 0;
            this.botonRosa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRosa.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonRosa.Location = new System.Drawing.Point(99, 154);
            this.botonRosa.Name = "botonRosa";
            this.botonRosa.Size = new System.Drawing.Size(187, 50);
            this.botonRosa.TabIndex = 10;
            this.botonRosa.Text = "Rosa";
            this.botonRosa.UseVisualStyleBackColor = false;
            this.botonRosa.Click += new System.EventHandler(this.botonRosa_Click);
            // 
            // botonAzul
            // 
            this.botonAzul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonAzul.FlatAppearance.BorderSize = 0;
            this.botonAzul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAzul.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonAzul.Location = new System.Drawing.Point(99, 98);
            this.botonAzul.Name = "botonAzul";
            this.botonAzul.Size = new System.Drawing.Size(187, 50);
            this.botonAzul.TabIndex = 8;
            this.botonAzul.Text = "Azul Marino";
            this.botonAzul.UseVisualStyleBackColor = false;
            this.botonAzul.Click += new System.EventHandler(this.botonAzul_Click);
            // 
            // botonAmarillo
            // 
            this.botonAmarillo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonAmarillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonAmarillo.FlatAppearance.BorderSize = 0;
            this.botonAmarillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAmarillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAmarillo.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonAmarillo.Location = new System.Drawing.Point(323, 154);
            this.botonAmarillo.Name = "botonAmarillo";
            this.botonAmarillo.Size = new System.Drawing.Size(187, 50);
            this.botonAmarillo.TabIndex = 5;
            this.botonAmarillo.Text = "Amarillo";
            this.botonAmarillo.UseVisualStyleBackColor = false;
            this.botonAmarillo.Click += new System.EventHandler(this.Amarillo_Click);
            // 
            // botonRojo
            // 
            this.botonRojo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonRojo.FlatAppearance.BorderSize = 0;
            this.botonRojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRojo.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonRojo.Location = new System.Drawing.Point(323, 42);
            this.botonRojo.Name = "botonRojo";
            this.botonRojo.Size = new System.Drawing.Size(187, 50);
            this.botonRojo.TabIndex = 6;
            this.botonRojo.Text = "Rojo";
            this.botonRojo.UseVisualStyleBackColor = false;
            this.botonRojo.Click += new System.EventHandler(this.botonRojo_Click);
            // 
            // botonBlanco
            // 
            this.botonBlanco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonBlanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonBlanco.FlatAppearance.BorderSize = 0;
            this.botonBlanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonBlanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBlanco.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonBlanco.Location = new System.Drawing.Point(99, 42);
            this.botonBlanco.Name = "botonBlanco";
            this.botonBlanco.Size = new System.Drawing.Size(187, 50);
            this.botonBlanco.TabIndex = 4;
            this.botonBlanco.Text = "Blanco";
            this.botonBlanco.UseVisualStyleBackColor = false;
            this.botonBlanco.Click += new System.EventHandler(this.botonBlanco_Click);
            // 
            // botonVerde
            // 
            this.botonVerde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonVerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonVerde.FlatAppearance.BorderSize = 0;
            this.botonVerde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVerde.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonVerde.Location = new System.Drawing.Point(323, 98);
            this.botonVerde.Name = "botonVerde";
            this.botonVerde.Size = new System.Drawing.Size(187, 50);
            this.botonVerde.TabIndex = 7;
            this.botonVerde.Text = "Verde";
            this.botonVerde.UseVisualStyleBackColor = false;
            this.botonVerde.Click += new System.EventHandler(this.botonVerde_Click);
            // 
            // botonPrender
            // 
            this.botonPrender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonPrender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonPrender.FlatAppearance.BorderSize = 0;
            this.botonPrender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonPrender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPrender.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonPrender.Location = new System.Drawing.Point(323, 299);
            this.botonPrender.Name = "botonPrender";
            this.botonPrender.Size = new System.Drawing.Size(150, 50);
            this.botonPrender.TabIndex = 4;
            this.botonPrender.Text = "Prender";
            this.botonPrender.UseVisualStyleBackColor = false;
            this.botonPrender.Click += new System.EventHandler(this.botonPrender_Click);
            // 
            // botonApagar
            // 
            this.botonApagar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botonApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonApagar.FlatAppearance.BorderSize = 0;
            this.botonApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonApagar.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonApagar.Location = new System.Drawing.Point(136, 299);
            this.botonApagar.Name = "botonApagar";
            this.botonApagar.Size = new System.Drawing.Size(150, 50);
            this.botonApagar.TabIndex = 5;
            this.botonApagar.Text = "Apagar";
            this.botonApagar.UseVisualStyleBackColor = false;
            this.botonApagar.Click += new System.EventHandler(this.botonApagar_Click);
            // 
            // FormLeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 361);
            this.Controls.Add(this.labelPuertoActual);
            this.Controls.Add(this.botonVerde);
            this.Controls.Add(this.botonBlanco);
            this.Controls.Add(this.botonRojo);
            this.Controls.Add(this.botonAmarillo);
            this.Controls.Add(this.botonAzul);
            this.Controls.Add(this.botonRosa);
            this.Controls.Add(this.botonCyan);
            this.Controls.Add(this.botonApagar);
            this.Controls.Add(this.botonPrender);
            this.Name = "FormLeds";
            this.Text = "Configuracion Led";
            this.Load += new System.EventHandler(this.FormLeds_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonRosa;
        private System.Windows.Forms.Button botonCyan;
        private System.Windows.Forms.Button botonAzul;
        private System.Windows.Forms.Button botonVerde;
        private System.Windows.Forms.Button botonRojo;
        private System.Windows.Forms.Button botonAmarillo;
        private System.Windows.Forms.Button botonBlanco;
        private System.Windows.Forms.Label labelPuertoActual;
        private System.Windows.Forms.Button botonPrender;
        private System.Windows.Forms.Button botonApagar;
    }
}