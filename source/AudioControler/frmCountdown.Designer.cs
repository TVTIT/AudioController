namespace AudioController
{
    partial class frmCountdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCountdown));
            this.btnStartStop = new System.Windows.Forms.Button();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.numSec = new System.Windows.Forms.NumericUpDown();
            this.timerGUI = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbMin = new System.Windows.Forms.Label();
            this.lbSec = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartStop
            // 
            this.btnStartStop.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.Location = new System.Drawing.Point(113, 58);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(88, 41);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "Bắt đầu";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(59, 31);
            this.numMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(44, 21);
            this.numMin.TabIndex = 1;
            this.toolTip1.SetToolTip(this.numMin, "Phút");
            this.numMin.ValueChanged += new System.EventHandler(this.numMin_ValueChanged);
            // 
            // numSec
            // 
            this.numSec.Location = new System.Drawing.Point(233, 31);
            this.numSec.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numSec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numSec.Name = "numSec";
            this.numSec.Size = new System.Drawing.Size(44, 21);
            this.numSec.TabIndex = 2;
            this.toolTip1.SetToolTip(this.numSec, "Giây");
            this.numSec.ValueChanged += new System.EventHandler(this.numSec_ValueChanged);
            // 
            // timerGUI
            // 
            this.timerGUI.Interval = 1000;
            this.timerGUI.Tick += new System.EventHandler(this.timerGUI_Tick);
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(21, 33);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(33, 14);
            this.lbMin.TabIndex = 3;
            this.lbMin.Text = "Phút";
            // 
            // lbSec
            // 
            this.lbSec.AutoSize = true;
            this.lbSec.Location = new System.Drawing.Point(198, 33);
            this.lbSec.Name = "lbSec";
            this.lbSec.Size = new System.Drawing.Size(29, 14);
            this.lbSec.TabIndex = 4;
            this.lbSec.Text = "Giây";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(106, 14);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(106, 41);
            this.lbTimer.TabIndex = 9;
            this.lbTimer.Text = "00:00";
            this.lbTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTimer.Visible = false;
            // 
            // frmCountdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 122);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbSec);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.numSec);
            this.Controls.Add(this.numMin);
            this.Controls.Add(this.btnStartStop);
            this.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCountdown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hẹn giờ tắt nhạc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCountdown_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numSec;
        private System.Windows.Forms.Timer timerGUI;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbSec;
        private System.Windows.Forms.Label lbTimer;
    }
}