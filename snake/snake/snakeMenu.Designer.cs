namespace snake
{
    partial class snakeMenu
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.gioca_btn = new System.Windows.Forms.Button();
            this.opzioni_btn = new System.Windows.Forms.Button();
            this.esci_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(154, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "SNAKE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gioca_btn
            // 
            this.gioca_btn.BackColor = System.Drawing.Color.Aqua;
            this.gioca_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioca_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gioca_btn.Location = new System.Drawing.Point(119, 149);
            this.gioca_btn.Name = "gioca_btn";
            this.gioca_btn.Size = new System.Drawing.Size(323, 88);
            this.gioca_btn.TabIndex = 1;
            this.gioca_btn.Text = "GIOCA";
            this.gioca_btn.UseVisualStyleBackColor = false;
            this.gioca_btn.Click += new System.EventHandler(this.gioca_btn_Click);
            // 
            // opzioni_btn
            // 
            this.opzioni_btn.BackColor = System.Drawing.Color.Aquamarine;
            this.opzioni_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opzioni_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.opzioni_btn.Location = new System.Drawing.Point(119, 277);
            this.opzioni_btn.Name = "opzioni_btn";
            this.opzioni_btn.Size = new System.Drawing.Size(323, 88);
            this.opzioni_btn.TabIndex = 2;
            this.opzioni_btn.Text = "OPZIONI";
            this.opzioni_btn.UseVisualStyleBackColor = false;
            this.opzioni_btn.Click += new System.EventHandler(this.opzioni_btn_Click);
            // 
            // esci_btn
            // 
            this.esci_btn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.esci_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esci_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.esci_btn.Location = new System.Drawing.Point(119, 405);
            this.esci_btn.Name = "esci_btn";
            this.esci_btn.Size = new System.Drawing.Size(323, 88);
            this.esci_btn.TabIndex = 3;
            this.esci_btn.Text = "ESCI";
            this.esci_btn.UseVisualStyleBackColor = false;
            this.esci_btn.Click += new System.EventHandler(this.esci_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // snakeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.esci_btn);
            this.Controls.Add(this.opzioni_btn);
            this.Controls.Add(this.gioca_btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "snakeMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "snake 1.0.0.0";
            this.Load += new System.EventHandler(this.snakeMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gioca_btn;
        private System.Windows.Forms.Button opzioni_btn;
        private System.Windows.Forms.Button esci_btn;
        private System.Windows.Forms.Timer timer1;
    }
}

