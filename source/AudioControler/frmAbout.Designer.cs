namespace AudioController
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGithub = new System.Windows.Forms.Button();
            this.btnGmail = new System.Windows.Forms.Button();
            this.btnFb = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Audio Controller v" + Updates.CurrentVer().ToString() + " - Điều khiển nhạc bằng bàn phím\r\nCopyright © Trung.The This 2021. All rights reserved\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGithub);
            this.groupBox2.Controls.Add(this.btnGmail);
            this.groupBox2.Controls.Add(this.btnFb);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 125);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liên hệ với mình tại:";
            // 
            // btnGithub
            // 
            this.btnGithub.Image = ((System.Drawing.Image)(resources.GetObject("btnGithub.Image")));
            this.btnGithub.Location = new System.Drawing.Point(305, 38);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(62, 62);
            this.btnGithub.TabIndex = 2;
            this.btnGithub.UseVisualStyleBackColor = true;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // btnGmail
            // 
            this.btnGmail.Image = ((System.Drawing.Image)(resources.GetObject("btnGmail.Image")));
            this.btnGmail.Location = new System.Drawing.Point(49, 38);
            this.btnGmail.Name = "btnGmail";
            this.btnGmail.Size = new System.Drawing.Size(62, 62);
            this.btnGmail.TabIndex = 1;
            this.btnGmail.UseVisualStyleBackColor = true;
            this.btnGmail.Click += new System.EventHandler(this.btnGmail_Click);
            // 
            // btnFb
            // 
            this.btnFb.Image = ((System.Drawing.Image)(resources.GetObject("btnFb.Image")));
            this.btnFb.Location = new System.Drawing.Point(177, 38);
            this.btnFb.Name = "btnFb";
            this.btnFb.Size = new System.Drawing.Size(62, 62);
            this.btnFb.TabIndex = 0;
            this.btnFb.UseVisualStyleBackColor = true;
            this.btnFb.Click += new System.EventHandler(this.btnFb_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 229);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About me";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGithub;
        private System.Windows.Forms.Button btnGmail;
        private System.Windows.Forms.Button btnFb;

    }
}