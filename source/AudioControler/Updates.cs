using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace AudioController
{
    class Updates
    {
        private static string str_download;

        public static void Check(bool is_startup)
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                using (WebClient wc = new WebClient())
                {
                    str_download = wc.DownloadString("https://tvtit.github.io/AudioController/version.txt");
                }
                string[] str_split = str_download.Split('\n');

                Version currVer = CurrentVer();
                Version newVer = new Version(str_split[0]);

                if (currVer < newVer)
                {
                    string str = null;
                    for (int i = 1; i < str_split.Length; i++)
                    {
                        str += str_split[i];
                    }
                    MessageBox.Show(str, "Kiểm tra cập nhật (Audio Controller)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult result = MessageBox.Show("Bạn đang sử dụng phiên bản " + currVer.ToString() + ". Bạn có muốn cập nhật lên phiên bản (" + newVer.ToString() + ") mới nhất không ?", "Cập nhật lên phiên bản mới", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DownloadAndInstall();
                    }
                }
                else if (!is_startup)
                {
                    MessageBox.Show("Bạn đang sử dụng phiên bản mới nhất", "Kiểm tra cập nhật (Audio Controller)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                if (!is_startup)
                {
                    MessageBox.Show("Kiếm tra cập nhật không thành công, vui lòng kiểm tra lại kết nối mạng\nThông báo lỗi: " + ex.Message, "Kiểm tra cập nhật (Audio Controller)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static void DownloadAndInstall()
        {
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile("https://tvtit.github.io/AudioController/AudioController.exe", Path.GetTempPath() + "\\AudioController.exe");
            }
            if (File.Exists(Path.GetTempPath() + "\\updateaudiocontroller.cmd"))
            {
                File.Delete(Path.GetTempPath() + "\\updateaudiocontroller.cmd");
            }
            using (StreamWriter writer = File.CreateText(Path.GetTempPath() + "\\updateaudiocontroller.cmd"))
            {
                writer.WriteLine("taskkill /IM " + AppDomain.CurrentDomain.FriendlyName + " /F");
                writer.WriteLine("timeout /t 1");
                writer.WriteLine("move /Y \"%temp%\\AudioController.exe\" \"" + Application.ExecutablePath + "\"");
                writer.WriteLine("cd /d " + AppDomain.CurrentDomain.BaseDirectory);
                writer.WriteLine("start " + AppDomain.CurrentDomain.FriendlyName + " /afterupdate");
                writer.WriteLine("del /f /q %temp%\\updateaudiocontroller.cmd");
            }
            using (Process proc_install = new Process())
            {
                proc_install.StartInfo.FileName = Path.GetTempPath() + "\\updateaudiocontroller.cmd";
                proc_install.StartInfo.UseShellExecute = false;
                proc_install.StartInfo.CreateNoWindow = true;
                proc_install.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc_install.StartInfo.RedirectStandardError = false;
                proc_install.StartInfo.RedirectStandardOutput = false;
                proc_install.Start();
            }
        }

        public static Version CurrentVer()
        {
            string returnVer = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string[] currVer = returnVer.Split('.');
            
            for (int i = currVer.Length - 1; i > 0; i--)
            {
                if (currVer[i] != "0")
                    break;
                else
                    returnVer = returnVer.Remove(returnVer.LastIndexOf('0') - 1, 2);
            }

            return (returnVer.Length == 1) ? new Version(returnVer + ".0") : new Version(returnVer);
        }
    }
}
