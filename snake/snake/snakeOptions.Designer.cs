namespace snake
{
    partial class snakeOptions
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
            this.volume_btn = new System.Windows.Forms.Button();
            this.livello_btn = new System.Windows.Forms.Button();
            this.esci_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // volume_btn
            // 
            this.volume_btn.BackColor = System.Drawing.Color.Lime;
            this.volume_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume_btn.Location = new System.Drawing.Point(118, 53);
            this.volume_btn.Name = "volume_btn";
            this.volume_btn.Size = new System.Drawing.Size(235, 75);
            this.volume_btn.TabIndex = 0;
            this.volume_btn.Text = "VOLUME ON";
            this.volume_btn.UseVisualStyleBackColor = false;
            this.volume_btn.Click += new System.EventHandler(this.volume_btn_Click);
            // 
            // livello_btn
            // 
            this.livello_btn.BackColor = System.Drawing.Color.Lime;
            this.livello_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livello_btn.Location = new System.Drawing.Point(118, 185);
            this.livello_btn.Name = "livello_btn";
            this.livello_btn.Size = new System.Drawing.Size(235, 75);
            this.livello_btn.TabIndex = 1;
            this.livello_btn.Text = "LIVELLO: 1";
            this.livello_btn.UseVisualStyleBackColor = false;
            this.livello_btn.Click += new System.EventHandler(this.livello_btn_Click);
            // 
            // esci_btn
            // 
            this.esci_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esci_btn.Location = new System.Drawing.Point(118, 314);
            this.esci_btn.Name = "esci_btn";
            this.esci_btn.Size = new System.Drawing.Size(235, 75);
            this.esci_btn.TabIndex = 2;
            this.esci_btn.Text = "ESCI";
            this.esci_btn.UseVisualStyleBackColor = true;
            this.esci_btn.Click += new System.EventHandler(this.esci_btn_Click);
            // 
            // snakeOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.esci_btn);
            this.Controls.Add(this.livello_btn);
            this.Controls.Add(this.volume_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "snakeOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "snakeOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button volume_btn;
        private System.Windows.Forms.Button livello_btn;
        private System.Windows.Forms.Button esci_btn;
    }
}