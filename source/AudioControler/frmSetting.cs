using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using AudioController.Properties;

namespace AudioController
{
    public partial class frmSetting : Form
    {
        private bool is_starting = true;
        private bool ForceClose = false;
        private KeysConverter kc = new KeysConverter();
        private bool ckstartup;
        private bool is_setting_saved = true;
        private bool autoUpdates;
        private frmCountdown countdown;
        private frmAbout about;

        public frmSetting()
       {
            CheckProcess();
            InitializeComponent();
            Load_Setting(true);
            hook.RunWorkerAsync();
            ChangeMessageBoxText();
            is_starting = false;
        }

        private void CheckProcess()
        {
            Process[] process = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
            if (process.Length >= 2)
            {
                MessageBox.Show("Audio Controller đã được chạy sẵn", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(0);
            }
        }

        public void Load_Setting(bool is_startup)
        {
            Settings.Load(is_startup, out ckstartup, out HookKeyboard.PP, out HookKeyboard.Prev, out HookKeyboard.Next, out HookKeyboard.Volume_Mute, out HookKeyboard.Volume_Down, out HookKeyboard.Volume_Up, out autoUpdates);
            ckbStartup.Checked = ckstartup;
            tbBindPP.Text = kc.ConvertToString(HookKeyboard.PP);
            tbBindPrev.Text = kc.ConvertToString(HookKeyboard.Prev);
            tbBindNext.Text = kc.ConvertToString(HookKeyboard.Next);
            tbVlMute.Text = kc.ConvertToString(HookKeyboard.Volume_Mute);
            tbVlDwn.Text = kc.ConvertToString(HookKeyboard.Volume_Down);
            tbVlUp.Text = kc.ConvertToString(HookKeyboard.Volume_Up);
            ckbCheckUpdates.Checked = autoUpdates;
        }

        private void ChangeMessageBoxText()
        {
            MessageBoxManager.Cancel = "Huỷ";
            MessageBoxManager.No = "Không";
            MessageBoxManager.Yes = "Có";
            MessageBoxManager.Register();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!is_setting_saved)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn lưu cài đặt không ?", "Lưu cài đặt", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    btnSaveSetting.PerformClick();
                else if (result == DialogResult.No)
                {
                    Load_Setting(false);
                    is_setting_saved = true;
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
            }
            if (!ForceClose)
            {
                e.Cancel = true;
                Hide();
                ShowInTaskbar = false;
            }
            ReadOnlyTb(true);
        }

        private void hook_DoWork(object sender, DoWorkEventArgs e)
        {
            if (autoUpdates)
                Updates.Check(true);
            HookKeyboard.Run();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            Hide();
            ShowInTaskbar = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ForceClose = true;
            Form1_FormClosing(null, new FormClosingEventArgs(CloseReason.ApplicationExitCall, false));
            hook.CancelAsync();
            Application.Exit();    //Some time not working (I don't know why)
            //Application.ExitThread();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
            Show();
        }

        private void DisEnableBtn(bool Enabled)
        {
            btnBindPP.Enabled = Enabled;
            btnPrev.Enabled = Enabled;
            btnNext.Enabled = Enabled;
            btnVlMute.Enabled = Enabled;
            btnVlDwn.Enabled = Enabled;
            btnVlUp.Enabled = Enabled;
        }

        private void ReadOnlyTb(bool ReadOnly)
        {
            tbBindPP.ReadOnly = ReadOnly;
            tbBindPrev.ReadOnly = ReadOnly;
            tbBindNext.ReadOnly = ReadOnly;
            tbVlMute.ReadOnly = ReadOnly;
            tbVlDwn.ReadOnly = ReadOnly;
            tbVlUp.ReadOnly = ReadOnly;
        }

        private void StartBindKey(Button btn, TextBox tb, ref Keys Bind)
        {
            DisEnableBtn(false);
            is_setting_saved = false;
            Bind = Keys.None;
            btn.Enabled = true;
            tb.ReadOnly = false;
            tb.Focus();
            tb.SelectAll();
            HookKeyboard.is_binding = true;
            while (HookKeyboard.is_binding)
            {
                Application.DoEvents();
            }

            DisEnableBtn(true);
            Bind = HookKeyboard.KeyBinding;
            tb.ReadOnly = true;
            btnCheckUpdates.Focus();
            tb.Text = kc.ConvertToString(HookKeyboard.KeyBinding);
        }

        private void btnBindPP_Click(object sender, EventArgs e)
        {
            StartBindKey(btnBindPP, tbBindPP, ref HookKeyboard.PP);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            StartBindKey(btnNext, tbBindNext, ref HookKeyboard.Next);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            StartBindKey(btnPrev, tbBindPrev, ref HookKeyboard.Prev);
        }

        private void btnVlMute_Click(object sender, EventArgs e)
        {
            StartBindKey(btnVlMute, tbVlMute, ref HookKeyboard.Volume_Mute);
        }

        private void btnVlUp_Click(object sender, EventArgs e)
        {
            StartBindKey(btnVlUp, tbVlUp, ref HookKeyboard.Volume_Up);
        }

        private void btnVlDwn_Click(object sender, EventArgs e)
        {
            StartBindKey(btnVlDwn, tbVlDwn, ref HookKeyboard.Volume_Down);
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            Settings.Write(ckbStartup.Checked, HookKeyboard.PP, HookKeyboard.Prev, HookKeyboard.Next, HookKeyboard.Volume_Mute, HookKeyboard.Volume_Down, HookKeyboard.Volume_Up, ckbCheckUpdates.Checked);
            Load_Setting(false);
            is_setting_saved = true;
            MessageBox.Show("Lưu cài đặt thành công!", "CÀI ĐẶT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
        }

        private void UnBind(TextBox tb, out Keys Bind)
        {
            DisEnableBtn(true);
            is_setting_saved = true;
            HookKeyboard.is_binding = false;
            is_setting_saved = false;
            Bind = Keys.None;
            tb.ReadOnly = true;
            tb.Text = "None";
        }

        private void btnClrPP_Click(object sender, EventArgs e)
        {
            UnBind(tbBindPP, out HookKeyboard.PP);
        }

        private void btnClrPrev_Click(object sender, EventArgs e)
        {
            UnBind(tbBindPrev, out HookKeyboard.Prev);
        }

        private void btnClrNext_Click(object sender, EventArgs e)
        {
            UnBind(tbBindNext, out HookKeyboard.Next);
        }

        private void btnClrMute_Click(object sender, EventArgs e)
        {
            UnBind(tbVlMute, out HookKeyboard.Volume_Mute);
        }

        private void btnClrDwn_Click(object sender, EventArgs e)
        {
            UnBind(tbVlDwn, out HookKeyboard.Volume_Down);
        }

        private void btnClrUp_Click(object sender, EventArgs e)
        {
            UnBind(tbVlUp, out HookKeyboard.Volume_Up);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (about == null)
                about = new frmAbout();
            else if (about.IsDisposed)
                about = new frmAbout();
            about.WindowState = FormWindowState.Normal;
            about.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (countdown == null)
                countdown = new frmCountdown();
            else if (countdown.IsDisposed)
                countdown = new frmCountdown();
            countdown.WindowState = FormWindowState.Normal;
            countdown.Show();
        }

        private void btnCheckUpdates_Click(object sender, EventArgs e)
        {
            Updates.Check(false);
        }

        private void ckbStartup_CheckedChanged(object sender, EventArgs e)
        {
            is_setting_saved = (is_starting) ? is_setting_saved : false;
        }

        private void ckbCheckUpdates_CheckedChanged(object sender, EventArgs e)
        {
            is_setting_saved = (is_starting) ? is_setting_saved : false;
        }

        private void preventSleepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreventSleep.PreventUnPrevent(preventSleepToolStripMenuItem.Checked);
            preventSleepToolStripMenuItem.Checked = !preventSleepToolStripMenuItem.Checked;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }
    }
}
