namespace flatUISerialPort.Forms
{
    partial class Otros
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botonGitHub = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::flatUISerialPort.Properties.Resources.hehe;
            this.pictureBox1.Location = new System.Drawing.Point(257, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // botonGitHub
            // 
            this.botonGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.botonGitHub.FlatAppearance.BorderSize = 0;
            this.botonGitHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGitHub.ForeColor = System.Drawing.Color.Gainsboro;
            this.botonGitHub.Location = new System.Drawing.Point(21, 46);
            this.botonGitHub.Name = "botonGitHub";
            this.botonGitHub.Size = new System.Drawing.Size(150, 50);
            this.botonGitHub.TabIndex = 5;
            this.botonGitHub.Text = "GitHub";
            this.botonGitHub.UseVisualStyleBackColor = false;
            this.botonGitHub.Click += new System.EventHandler(this.botonGitHub_Click);
            // 
            // Otros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 361);
            this.Controls.Add(this.botonGitHub);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Otros";
            this.Text = "Otros";
            this.Load += new System.EventHandler(this.Otros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonGitHub;
    }
}