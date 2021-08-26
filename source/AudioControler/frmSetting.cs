using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using AudioController.Properties;
using System.Net;

namespace AudioController
{
    public partial class frmSetting : Form
    {

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

        private void Load_Setting(bool is_startup)
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
                DialogResult result = MessageBox.Show("Bạn có muốn lưu cài đặt không?", "CÀI ĐẶT", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
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
            tbBindPP.Enabled = false;
            tbBindPrev.Enabled = false;
            tbBindNext.Enabled = false;
            tbVlMute.Enabled = false;
            tbVlDwn.Enabled = false;
            tbVlUp.Enabled = false;
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
            Application.Exit();    //Some time not working (I don't know why)
            //Application.ExitThread();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            is_setting_saved = true;
            ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            Show();
        }

        private void btnBindPP_Click(object sender, EventArgs e)
        {
            is_setting_saved = false;
            HookKeyboard.PP = Keys.None;
            tbBindPP.Enabled = true;
            tbBindPP.Focus();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            is_setting_saved = false;
            HookKeyboard.Next = Keys.None;
            tbBindNext.Enabled = true;
            tbBindNext.Focus();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            is_setting_saved = false;
            HookKeyboard.Prev = Keys.None;
            tbBindPrev.Enabled = true;
            tbBindPrev.Focus();
        }

        private void btnVlMute_Click(object sender, EventArgs e)
        {
            is_setting_saved = false;
            HookKeyboard.Volume_Mute = Keys.None;
            tbVlMute.Enabled = true;
            tbVlMute.Focus();
        }

        private void btnVlUp_Click(object sender, EventArgs e)
        {
            is_setting_saved = false;
            HookKeyboard.Volume_Up = Keys.None;
            tbVlUp.Enabled = true;
            tbVlUp.Focus();
        }

        private void btnVlDwn_Click(object sender, EventArgs e)
        {
            is_setting_saved = false;
            HookKeyboard.Volume_Down = Keys.None;
            tbVlDwn.Enabled = true;
            tbVlDwn.Focus();
        }

        private void tbBindPP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.None)
            {
                HookKeyboard.PP = e.KeyCode;
                tbBindPP.Enabled = false;
                tbBindPP.Text = kc.ConvertToString(HookKeyboard.PP);
            }
        }

        private void tbBindPrev_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.None)
            {
                HookKeyboard.Prev = e.KeyCode;
                tbBindPrev.Enabled = false;
                tbBindPrev.Text = kc.ConvertToString(HookKeyboard.Prev);
            }
        }

        private void tbBindNext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.None)
            {
                HookKeyboard.Next = e.KeyCode;
                tbBindNext.Enabled = false;
                tbBindNext.Text = kc.ConvertToString(HookKeyboard.Next);
            }
        }

        private void tbVlMute_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.None)
            {
                HookKeyboard.Volume_Mute = e.KeyCode;
                tbVlMute.Enabled = false;
                tbVlMute.Text = kc.ConvertToString(HookKeyboard.Volume_Mute);
            }
        }

        private void tbVlDwn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.None)
            {
                HookKeyboard.Volume_Down = e.KeyCode;
                tbVlDwn.Enabled = false;
                tbVlDwn.Text = kc.ConvertToString(HookKeyboard.Volume_Down);
            }
        }

        private void tbVlUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.None)
            {
                HookKeyboard.Volume_Up = e.KeyCode;
                tbVlUp.Enabled = false;
                tbVlUp.Text = kc.ConvertToString(HookKeyboard.Volume_Up);
            }
        }

        private void tbBindPP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbBindPrev_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbBindNext_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbVlMute_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbVlDwn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbVlUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            Settings.Write(ckbStartup.Checked, HookKeyboard.PP, HookKeyboard.Prev, HookKeyboard.Next, HookKeyboard.Volume_Mute, HookKeyboard.Volume_Down, HookKeyboard.Volume_Up, ckbCheckUpdates.Checked);
            Load_Setting(false);
            is_setting_saved = true;
            MessageBox.Show("Lưu cài đặt thành công!", "CÀI ĐẶT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
        }

        private void btnClrPP_Click(object sender, EventArgs e)
        {
            is_setting_saved = false;
            HookKeyboard.PP = Keys.None;
            tbBindPP.Enabled = false;
            tbBindPP.Text = "None";
        }

        private void btnClrPrev_Click(object sender, EventArgs e)
        {
            is_setting_saved = false;
            HookKeyboard.Prev = Keys.None;
            tbBindPrev.Enabled = false;
            tbBindPrev.Text = "None";
        }

        private void btnClrNext_Click(object sender, EventArgs e)
        {
            is_setting_saved = false;
            HookKeyboard.Next = Keys.None;
            tbBindNext.Enabled = false;
            tbBindNext.Text = "None";
        }

        private void btnClrMute_Click(object sender, EventArgs e)
        {
            is_setting_saved = false;
            HookKeyboard.Volume_Mute = Keys.None;
            tbVlMute.Enabled = false;
            tbVlMute.Text = "None";
        }

        private void btnClrDwn_Click(object sender, EventArgs e)
        {
            is_setting_saved = false;
            HookKeyboard.Volume_Down = Keys.None;
            tbVlDwn.Enabled = false;
            tbVlDwn.Text = "None";
        }

        private void btnClrUp_Click(object sender, EventArgs e)
        {
            is_setting_saved = false;
            HookKeyboard.Volume_Up = Keys.None;
            tbVlUp.Enabled = false;
            tbVlUp.Text = "None";
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
            is_setting_saved = false;
        }

        private void ckbCheckUpdates_CheckedChanged(object sender, EventArgs e)
        {
            is_setting_saved = false;
        }
    }
}
