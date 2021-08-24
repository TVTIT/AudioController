using System;
using System.Windows.Forms;
namespace AudioController
{
    partial class frmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.hook = new System.ComponentModel.BackgroundWorker();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveSetting = new System.Windows.Forms.Button();
            this.tbBindPP = new System.Windows.Forms.TextBox();
            this.tbBindNext = new System.Windows.Forms.TextBox();
            this.tbBindPrev = new System.Windows.Forms.TextBox();
            this.btnBindPP = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClrUp = new System.Windows.Forms.Button();
            this.btnClrMute = new System.Windows.Forms.Button();
            this.btnClrDwn = new System.Windows.Forms.Button();
            this.btnClrPrev = new System.Windows.Forms.Button();
            this.btnClrPP = new System.Windows.Forms.Button();
            this.btnClrNext = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVlUp = new System.Windows.Forms.TextBox();
            this.btnVlUp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbVlMute = new System.Windows.Forms.TextBox();
            this.btnVlMute = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVlDwn = new System.Windows.Forms.TextBox();
            this.btnVlDwn = new System.Windows.Forms.Button();
            this.ckbStartup = new System.Windows.Forms.CheckBox();
            this.btnCheckUpdates = new System.Windows.Forms.Button();
            this.ckbCheckUpdates = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hook
            // 
            this.hook.DoWork += new System.ComponentModel.DoWorkEventHandler(this.hook_DoWork);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Audio Controller";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.settingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 92);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.aboutToolStripMenuItem.Text = "About Audio Controller";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItem1.Text = "Hẹn giờ tắt nhạc";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.settingToolStripMenuItem.Text = "Cài đặt";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.exitToolStripMenuItem.Text = "Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnSaveSetting
            // 
            this.btnSaveSetting.Location = new System.Drawing.Point(302, 254);
            this.btnSaveSetting.Name = "btnSaveSetting";
            this.btnSaveSetting.Size = new System.Drawing.Size(84, 37);
            this.btnSaveSetting.TabIndex = 1;
            this.btnSaveSetting.Text = "Lưu cài đặt";
            this.btnSaveSetting.UseVisualStyleBackColor = true;
            this.btnSaveSetting.Click += new System.EventHandler(this.btnSaveSetting_Click);
            // 
            // tbBindPP
            // 
            this.tbBindPP.Enabled = false;
            this.tbBindPP.Location = new System.Drawing.Point(122, 24);
            this.tbBindPP.Name = "tbBindPP";
            this.tbBindPP.Size = new System.Drawing.Size(82, 21);
            this.tbBindPP.TabIndex = 2;
            this.tbBindPP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBindPP_KeyDown);
            this.tbBindPP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBindPP_KeyPress);
            // 
            // tbBindNext
            // 
            this.tbBindNext.Enabled = false;
            this.tbBindNext.Location = new System.Drawing.Point(122, 90);
            this.tbBindNext.Name = "tbBindNext";
            this.tbBindNext.Size = new System.Drawing.Size(82, 21);
            this.tbBindNext.TabIndex = 3;
            this.tbBindNext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBindNext_KeyDown);
            this.tbBindNext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBindNext_KeyPress);
            // 
            // tbBindPrev
            // 
            this.tbBindPrev.Enabled = false;
            this.tbBindPrev.Location = new System.Drawing.Point(122, 57);
            this.tbBindPrev.Name = "tbBindPrev";
            this.tbBindPrev.Size = new System.Drawing.Size(82, 21);
            this.tbBindPrev.TabIndex = 4;
            this.tbBindPrev.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbBindPrev_KeyDown);
            this.tbBindPrev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBindPrev_KeyPress);
            // 
            // btnBindPP
            // 
            this.btnBindPP.Location = new System.Drawing.Point(212, 24);
            this.btnBindPP.Name = "btnBindPP";
            this.btnBindPP.Size = new System.Drawing.Size(73, 25);
            this.btnBindPP.TabIndex = 5;
            this.btnBindPP.Text = "Gán phím";
            this.btnBindPP.UseVisualStyleBackColor = true;
            this.btnBindPP.Click += new System.EventHandler(this.btnBindPP_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(212, 90);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(73, 25);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Gán phím";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(212, 57);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(73, 25);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "Gán phím";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dừng/Phát ▷/❚❚";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bài trước ||◁";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bài sau ▷||";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClrUp);
            this.groupBox1.Controls.Add(this.btnClrMute);
            this.groupBox1.Controls.Add(this.btnClrDwn);
            this.groupBox1.Controls.Add(this.btnClrPrev);
            this.groupBox1.Controls.Add(this.btnClrPP);
            this.groupBox1.Controls.Add(this.btnClrNext);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbVlUp);
            this.groupBox1.Controls.Add(this.btnVlUp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbVlMute);
            this.groupBox1.Controls.Add(this.btnVlMute);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbVlDwn);
            this.groupBox1.Controls.Add(this.btnVlDwn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbBindPP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbBindNext);
            this.groupBox1.Controls.Add(this.tbBindPrev);
            this.groupBox1.Controls.Add(this.btnPrev);
            this.groupBox1.Controls.Add(this.btnBindPP);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 232);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt bàn phím";
            // 
            // btnClrUp
            // 
            this.btnClrUp.Location = new System.Drawing.Point(292, 191);
            this.btnClrUp.Name = "btnClrUp";
            this.btnClrUp.Size = new System.Drawing.Size(73, 25);
            this.btnClrUp.TabIndex = 25;
            this.btnClrUp.Text = "Xoá phím";
            this.btnClrUp.UseVisualStyleBackColor = true;
            this.btnClrUp.Click += new System.EventHandler(this.btnClrUp_Click);
            // 
            // btnClrMute
            // 
            this.btnClrMute.Location = new System.Drawing.Point(292, 124);
            this.btnClrMute.Name = "btnClrMute";
            this.btnClrMute.Size = new System.Drawing.Size(73, 25);
            this.btnClrMute.TabIndex = 24;
            this.btnClrMute.Text = "Xoá phím";
            this.btnClrMute.UseVisualStyleBackColor = true;
            this.btnClrMute.Click += new System.EventHandler(this.btnClrMute_Click);
            // 
            // btnClrDwn
            // 
            this.btnClrDwn.Location = new System.Drawing.Point(292, 157);
            this.btnClrDwn.Name = "btnClrDwn";
            this.btnClrDwn.Size = new System.Drawing.Size(73, 25);
            this.btnClrDwn.TabIndex = 23;
            this.btnClrDwn.Text = "Xoá phím";
            this.btnClrDwn.UseVisualStyleBackColor = true;
            this.btnClrDwn.Click += new System.EventHandler(this.btnClrDwn_Click);
            // 
            // btnClrPrev
            // 
            this.btnClrPrev.Location = new System.Drawing.Point(292, 57);
            this.btnClrPrev.Name = "btnClrPrev";
            this.btnClrPrev.Size = new System.Drawing.Size(73, 25);
            this.btnClrPrev.TabIndex = 22;
            this.btnClrPrev.Text = "Xoá phím";
            this.btnClrPrev.UseVisualStyleBackColor = true;
            this.btnClrPrev.Click += new System.EventHandler(this.btnClrPrev_Click);
            // 
            // btnClrPP
            // 
            this.btnClrPP.Location = new System.Drawing.Point(292, 24);
            this.btnClrPP.Name = "btnClrPP";
            this.btnClrPP.Size = new System.Drawing.Size(73, 25);
            this.btnClrPP.TabIndex = 20;
            this.btnClrPP.Text = "Xoá phím";
            this.btnClrPP.UseVisualStyleBackColor = true;
            this.btnClrPP.Click += new System.EventHandler(this.btnClrPP_Click);
            // 
            // btnClrNext
            // 
            this.btnClrNext.Location = new System.Drawing.Point(292, 90);
            this.btnClrNext.Name = "btnClrNext";
            this.btnClrNext.Size = new System.Drawing.Size(73, 25);
            this.btnClrNext.TabIndex = 21;
            this.btnClrNext.Text = "Xoá phím";
            this.btnClrNext.UseVisualStyleBackColor = true;
            this.btnClrNext.Click += new System.EventHandler(this.btnClrNext_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 14);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tăng âm lượng 🔈+";
            // 
            // tbVlUp
            // 
            this.tbVlUp.Enabled = false;
            this.tbVlUp.Location = new System.Drawing.Point(122, 191);
            this.tbVlUp.Name = "tbVlUp";
            this.tbVlUp.Size = new System.Drawing.Size(82, 21);
            this.tbVlUp.TabIndex = 17;
            this.tbVlUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbVlUp_KeyDown);
            this.tbVlUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVlUp_KeyPress);
            // 
            // btnVlUp
            // 
            this.btnVlUp.Location = new System.Drawing.Point(212, 191);
            this.btnVlUp.Name = "btnVlUp";
            this.btnVlUp.Size = new System.Drawing.Size(73, 25);
            this.btnVlUp.TabIndex = 18;
            this.btnVlUp.Text = "Gán phím";
            this.btnVlUp.UseVisualStyleBackColor = true;
            this.btnVlUp.Click += new System.EventHandler(this.btnVlUp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Bật/Tắt tiếng 🔇";
            // 
            // tbVlMute
            // 
            this.tbVlMute.Enabled = false;
            this.tbVlMute.Location = new System.Drawing.Point(122, 124);
            this.tbVlMute.Name = "tbVlMute";
            this.tbVlMute.Size = new System.Drawing.Size(82, 21);
            this.tbVlMute.TabIndex = 14;
            this.tbVlMute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbVlMute_KeyDown);
            this.tbVlMute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVlMute_KeyPress);
            // 
            // btnVlMute
            // 
            this.btnVlMute.Location = new System.Drawing.Point(212, 124);
            this.btnVlMute.Name = "btnVlMute";
            this.btnVlMute.Size = new System.Drawing.Size(73, 25);
            this.btnVlMute.TabIndex = 15;
            this.btnVlMute.Text = "Gán phím";
            this.btnVlMute.UseVisualStyleBackColor = true;
            this.btnVlMute.Click += new System.EventHandler(this.btnVlMute_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giảm âm lượng 🔈-";
            // 
            // tbVlDwn
            // 
            this.tbVlDwn.Enabled = false;
            this.tbVlDwn.Location = new System.Drawing.Point(122, 157);
            this.tbVlDwn.Name = "tbVlDwn";
            this.tbVlDwn.Size = new System.Drawing.Size(82, 21);
            this.tbVlDwn.TabIndex = 11;
            this.tbVlDwn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbVlDwn_KeyDown);
            this.tbVlDwn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbVlDwn_KeyPress);
            // 
            // btnVlDwn
            // 
            this.btnVlDwn.Location = new System.Drawing.Point(212, 157);
            this.btnVlDwn.Name = "btnVlDwn";
            this.btnVlDwn.Size = new System.Drawing.Size(73, 25);
            this.btnVlDwn.TabIndex = 12;
            this.btnVlDwn.Text = "Gán phím";
            this.btnVlDwn.UseVisualStyleBackColor = true;
            this.btnVlDwn.Click += new System.EventHandler(this.btnVlDwn_Click);
            // 
            // ckbStartup
            // 
            this.ckbStartup.AutoSize = true;
            this.ckbStartup.Location = new System.Drawing.Point(20, 254);
            this.ckbStartup.Name = "ckbStartup";
            this.ckbStartup.Size = new System.Drawing.Size(166, 18);
            this.ckbStartup.TabIndex = 12;
            this.ckbStartup.Text = "Khởi động cùng Windows";
            this.ckbStartup.UseVisualStyleBackColor = true;
            this.ckbStartup.CheckedChanged += new System.EventHandler(this.ckbStartup_CheckedChanged);
            // 
            // btnCheckUpdates
            // 
            this.btnCheckUpdates.Location = new System.Drawing.Point(222, 254);
            this.btnCheckUpdates.Name = "btnCheckUpdates";
            this.btnCheckUpdates.Size = new System.Drawing.Size(73, 37);
            this.btnCheckUpdates.TabIndex = 14;
            this.btnCheckUpdates.Text = "Kiểm tra cập nhật";
            this.btnCheckUpdates.UseVisualStyleBackColor = true;
            this.btnCheckUpdates.Click += new System.EventHandler(this.btnCheckUpdates_Click);
            // 
            // ckbCheckUpdates
            // 
            this.ckbCheckUpdates.AutoSize = true;
            this.ckbCheckUpdates.Location = new System.Drawing.Point(19, 278);
            this.ckbCheckUpdates.Name = "ckbCheckUpdates";
            this.ckbCheckUpdates.Size = new System.Drawing.Size(174, 32);
            this.ckbCheckUpdates.TabIndex = 15;
            this.ckbCheckUpdates.Text = "Tự động kiểm tra cập nhật\r\nmỗi lần khởi động";
            this.ckbCheckUpdates.UseVisualStyleBackColor = true;
            this.ckbCheckUpdates.CheckedChanged += new System.EventHandler(this.ckbCheckUpdates_CheckedChanged);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 308);
            this.Controls.Add(this.ckbCheckUpdates);
            this.Controls.Add(this.btnCheckUpdates);
            this.Controls.Add(this.ckbStartup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveSetting);
            this.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt (Audio Controller)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker hook;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem settingToolStripMenuItem;
        private Button btnSaveSetting;
        private TextBox tbBindPP;
        private TextBox tbBindNext;
        private TextBox tbBindPrev;
        private Button btnBindPP;
        private Button btnNext;
        private Button btnPrev;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private CheckBox ckbStartup;
        private Label label5;
        private TextBox tbVlMute;
        private Button btnVlMute;
        private Label label4;
        private TextBox tbVlDwn;
        private Button btnVlDwn;
        private Label label6;
        private TextBox tbVlUp;
        private Button btnVlUp;
        private Button btnClrUp;
        private Button btnClrMute;
        private Button btnClrDwn;
        private Button btnClrPrev;
        private Button btnClrPP;
        private Button btnClrNext;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private Button btnCheckUpdates;
        private CheckBox ckbCheckUpdates;
    }
}

