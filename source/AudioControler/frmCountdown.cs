using System;
using System.Drawing;
using System.Windows.Forms;

namespace AudioController
{
    public partial class frmCountdown : Form
    {
        public bool is_running = false;
        private int min;
        private int sec;

        public frmCountdown()
        {
            InitializeComponent();
        }

        private string XuLyStr(int i)
        {
            if (i < 10)
                return "0" + i.ToString();
            else
                return i.ToString();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (is_running)
            {
                Stop();
            }
            else
            {
                Start();
            }
        }

        private void timerGUI_Tick(object sender, EventArgs e)
        {
            if (sec == 0)
            {
                sec = 59;
                min--;
            }
            else
                sec--;
            lbTimer.Text = XuLyStr(min) + ":" + XuLyStr(sec);
            if (min == 0 && sec == 0)
            {
                HookKeyboard.PlayPauseMusic();
                timerGUI.Stop();
            }
        }

        private void Start()
        {
            if (numMin.Value == 0 && numSec.Value == 0)
            {
                Stop();
                return;
            }
            is_running = true;
            btnStartStop.Text = "Huỷ";
            numMin.Visible = false;
            numSec.Visible = false;
            lbMin.Visible = false;
            lbSec.Visible = false;
            min = (int)numMin.Value;
            sec = (int)numSec.Value;
            lbTimer.Text = XuLyStr(min) + ":" + XuLyStr(sec);
            lbTimer.Visible = true;
            timerGUI.Start();
        }

        private void Stop()
        {
            is_running = false;
            btnStartStop.Text = "Bắt đầu";
            numMin.Visible = true;
            lbMin.Visible = true;
            lbSec.Visible = true;
            numSec.Visible = true;
            lbTimer.Visible = false;
            timerGUI.Stop();
        }

        private void frmCountdown_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (is_running)
            {
                Hide();
                e.Cancel = true;
            }
        }

        private void numMin_ValueChanged(object sender, EventArgs e)
        {
            if (numMin.Value > numMin.Maximum - 1)
                numMin.Value = numMin.Minimum + 1;
            if (numMin.Value < numMin.Minimum + 1)
                numMin.Value = numMin.Maximum - 1;
        }

        private void numSec_ValueChanged(object sender, EventArgs e)
        {
            if (numSec.Value > numSec.Maximum - 1)
                numSec.Value = numSec.Minimum + 1;
            if (numSec.Value < numSec.Minimum + 1)
                numSec.Value = numSec.Maximum - 1;
        }
    }
}
