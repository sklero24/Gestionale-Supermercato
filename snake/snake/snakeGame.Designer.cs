namespace snake
{
    partial class snakeGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(snakeGame));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.punti_lbl = new System.Windows.Forms.Label();
            this.bigFoodTimer_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // punti_lbl
            // 
            this.punti_lbl.AutoSize = true;
            this.punti_lbl.BackColor = System.Drawing.Color.Lime;
            this.punti_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punti_lbl.Location = new System.Drawing.Point(13, 13);
            this.punti_lbl.Name = "punti_lbl";
            this.punti_lbl.Size = new System.Drawing.Size(18, 20);
            this.punti_lbl.TabIndex = 0;
            this.punti_lbl.Text = "0";
            this.punti_lbl.Click += new System.EventHandler(this.punti_lbl_Click);
            // 
            // bigFoodTimer_lbl
            // 
            this.bigFoodTimer_lbl.AutoSize = true;
            this.bigFoodTimer_lbl.BackColor = System.Drawing.Color.Beige;
            this.bigFoodTimer_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigFoodTimer_lbl.Location = new System.Drawing.Point(442, 13);
            this.bigFoodTimer_lbl.Name = "bigFoodTimer_lbl";
            this.bigFoodTimer_lbl.Size = new System.Drawing.Size(0, 20);
            this.bigFoodTimer_lbl.TabIndex = 1;
            // 
            // snakeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.bigFoodTimer_lbl);
            this.Controls.Add(this.punti_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "snakeGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "snakeGame 1.0.0.0";
            this.Load += new System.EventHandler(this.snakeGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label punti_lbl;
        private System.Windows.Forms.Label bigFoodTimer_lbl;
    }
}