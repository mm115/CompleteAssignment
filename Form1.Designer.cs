namespace CompleteAssignment
{
    partial class Form1
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
            this.Spin = new System.Windows.Forms.Button();
            this.Shoot = new System.Windows.Forms.Button();
            this.StartAgain = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Spin
            // 
            this.Spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin.Location = new System.Drawing.Point(53, 664);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(127, 68);
            this.Spin.TabIndex = 1;
            this.Spin.Text = "Spin";
            this.Spin.UseVisualStyleBackColor = true;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // Shoot
            // 
            this.Shoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shoot.Location = new System.Drawing.Point(227, 664);
            this.Shoot.Name = "Shoot";
            this.Shoot.Size = new System.Drawing.Size(127, 68);
            this.Shoot.TabIndex = 2;
            this.Shoot.Text = "Shoot";
            this.Shoot.UseVisualStyleBackColor = true;
            this.Shoot.Click += new System.EventHandler(this.Shoot_Click);
            // 
            // StartAgain
            // 
            this.StartAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartAgain.Location = new System.Drawing.Point(549, 664);
            this.StartAgain.Name = "StartAgain";
            this.StartAgain.Size = new System.Drawing.Size(240, 68);
            this.StartAgain.TabIndex = 4;
            this.StartAgain.Text = "Start Again ";
            this.StartAgain.UseVisualStyleBackColor = true;
            this.StartAgain.Click += new System.EventHandler(this.StartAgain_Click);
            // 
            // Load
            // 
            this.Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load.Location = new System.Drawing.Point(624, 25);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(165, 64);
            this.Load.TabIndex = 5;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "Crazy Shooters";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::CompleteAssignment.Properties.Resources.s_l1000;
            this.pictureBox1.Location = new System.Drawing.Point(53, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(736, 513);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(891, 765);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.StartAgain);
            this.Controls.Add(this.Shoot);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.Button Shoot;
        private System.Windows.Forms.Button StartAgain;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Label label1;
    }
}

