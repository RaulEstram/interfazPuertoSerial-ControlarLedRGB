namespace flatUISerialPort.Forms
{
    partial class FormSerialPort
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
            this.labelPuertoSerial = new System.Windows.Forms.Label();
            this.labelPuertoSerialSeleccionado = new System.Windows.Forms.Label();
            this.listaPuertosSeriales = new System.Windows.Forms.ComboBox();
            this.botonConectarPuertoSerial = new System.Windows.Forms.Button();
            this.botonActualizarPuertosSeriales = new System.Windows.Forms.Button();
            this.botonDesconectarPuertoSerial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPuertoSerial
            // 
            this.labelPuertoSerial.AutoSize = true;
            this.labelPuertoSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuertoSerial.ForeColor = System.Drawing.Color.Black;
            this.labelPuertoSerial.Location = new System.Drawing.Point(13, 13);
            this.labelPuertoSerial.Name = "labelPuertoSerial";
            this.labelPuertoSerial.Size = new System.Drawing.Size(179, 24);
            this.labelPuertoSerial.TabIndex = 0;
            this.labelPuertoSerial.Text = "Puerto Serial Actual:";
            // 
            // labelPuertoSerialSeleccionado
            // 
            this.labelPuertoSerialSeleccionado.AutoSize = true;
            this.labelPuertoSerialSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuertoSerialSeleccionado.ForeColor = System.Drawing.Color.Black;
            this.labelPuertoSerialSeleccionado.Location = new System.Drawing.Point(198, 13);
            this.labelPuertoSerialSeleccionado.Name = "labelPuertoSerialSeleccionado";
            this.labelPuertoSerialSeleccionado.Size = new System.Drawing.Size(132, 24);
            this.labelPuertoSerialSeleccionado.TabIndex = 1;
            this.labelPuertoSerialSeleccionado.Text = "No Conectado";
            // 
            // listaPuertosSeriales
            // 
            this.listaPuertosSeriales.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listaPuertosSeriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaPuertosSeriales.FormattingEnabled = true;
            this.listaPuertosSeriales.Location = new System.Drawing.Point(17, 50);
            this.listaPuertosSeriales.Name = "listaPuertosSeriales";
            this.listaPuertosSeriales.Size = new System.Drawing.Size(219, 28);
            this.listaPuertosSeriales.TabIndex = 2;
            // 
            // botonConectarPuertoSerial
            // 
            this.botonConectarPuertoSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonConectarPuertoSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonConectarPuertoSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonConectarPuertoSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConectarPuertoSerial.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonConectarPuertoSerial.Location = new System.Drawing.Point(447, 308);
            this.botonConectarPuertoSerial.Name = "botonConectarPuertoSerial";
            this.botonConectarPuertoSerial.Size = new System.Drawing.Size(144, 41);
            this.botonConectarPuertoSerial.TabIndex = 3;
            this.botonConectarPuertoSerial.Text = "Conectar";
            this.botonConectarPuertoSerial.UseVisualStyleBackColor = false;
            this.botonConectarPuertoSerial.Click += new System.EventHandler(this.botonConectarPuertoSerial_Click);
            // 
            // botonActualizarPuertosSeriales
            // 
            this.botonActualizarPuertosSeriales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botonActualizarPuertosSeriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonActualizarPuertosSeriales.FlatAppearance.BorderSize = 0;
            this.botonActualizarPuertosSeriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonActualizarPuertosSeriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonActualizarPuertosSeriales.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonActualizarPuertosSeriales.Location = new System.Drawing.Point(11, 308);
            this.botonActualizarPuertosSeriales.Name = "botonActualizarPuertosSeriales";
            this.botonActualizarPuertosSeriales.Size = new System.Drawing.Size(225, 41);
            this.botonActualizarPuertosSeriales.TabIndex = 4;
            this.botonActualizarPuertosSeriales.Text = "Actualizar Puertos Seriales";
            this.botonActualizarPuertosSeriales.UseVisualStyleBackColor = false;
            this.botonActualizarPuertosSeriales.Click += new System.EventHandler(this.botonActualizarPuertosSeriales_Click);
            // 
            // botonDesconectarPuertoSerial
            // 
            this.botonDesconectarPuertoSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonDesconectarPuertoSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonDesconectarPuertoSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonDesconectarPuertoSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDesconectarPuertoSerial.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonDesconectarPuertoSerial.Location = new System.Drawing.Point(297, 308);
            this.botonDesconectarPuertoSerial.Name = "botonDesconectarPuertoSerial";
            this.botonDesconectarPuertoSerial.Size = new System.Drawing.Size(144, 41);
            this.botonDesconectarPuertoSerial.TabIndex = 5;
            this.botonDesconectarPuertoSerial.Text = "Desconectar";
            this.botonDesconectarPuertoSerial.UseVisualStyleBackColor = false;
            this.botonDesconectarPuertoSerial.Click += new System.EventHandler(this.botonDesconectarPuertoSerial_Click);
            // 
            // FormSerialPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 361);
            this.Controls.Add(this.botonDesconectarPuertoSerial);
            this.Controls.Add(this.botonActualizarPuertosSeriales);
            this.Controls.Add(this.botonConectarPuertoSerial);
            this.Controls.Add(this.listaPuertosSeriales);
            this.Controls.Add(this.labelPuertoSerialSeleccionado);
            this.Controls.Add(this.labelPuertoSerial);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FormSerialPort";
            this.Text = "Configuracion Puerto Serial";
            this.Load += new System.EventHandler(this.FormSerialPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPuertoSerial;
        private System.Windows.Forms.Label labelPuertoSerialSeleccionado;
        private System.Windows.Forms.ComboBox listaPuertosSeriales;
        private System.Windows.Forms.Button botonConectarPuertoSerial;
        private System.Windows.Forms.Button botonActualizarPuertosSeriales;
        private System.Windows.Forms.Button botonDesconectarPuertoSerial;
    }
}