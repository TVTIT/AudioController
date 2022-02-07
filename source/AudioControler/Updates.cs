using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using System.IO.Compression;
using System.Xml;

namespace AudioController
{
    class Updates
    {
        private const string UPDATE_XML_LINK = "https://tvtit.github.io/AudioController/update.xml";

        private static string update_ver, update_msg, update_link;

        public static void Check(bool is_startup)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            try
            {
                using (XmlReader reader = XmlReader.Create(UPDATE_XML_LINK))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            switch (reader.Name.ToString())
                            {
                                case "Version":
                                    update_ver = reader.ReadString();
                                    break;
                                case "UpdateMsg":
                                    update_msg = reader.ReadString();
                                    break;
                                case "UpdateLink":
                                    update_link = reader.ReadString();
                                    break;
                            }
                        }
                    }
                }

                Version currVer = CurrentVer();
                Version newVer = new Version(update_ver);

                if (currVer < newVer)
                {
                    MessageBox.Show(update_msg, "Kiểm tra cập nhật (Audio Controller)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult result = MessageBox.Show($"Bạn đang sử dụng phiên bản {currVer.ToString()}. Bạn có muốn cập nhật lên phiên bản mới nhất ({newVer.ToString()}) không ?", "Cập nhật lên phiên bản mới", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                    MessageBox.Show($"Kiếm tra cập nhật không thành công, vui lòng kiểm tra lại kết nối mạng\nThông báo lỗi: {ex.Message}\nMã lỗi: {string.Format("0x{0:x}", ex.HResult)}", "Kiểm tra cập nhật (Audio Controller)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
		
        private static void DownloadAndInstall()
        {
            string download_update_zip = Path.GetTempPath() + "\\AudioController.zip";
            string cmdFilePath = Path.GetTempPath() + "\\UpdateAudioController.cmd";
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile(update_link, download_update_zip);
            }
            if (File.Exists(cmdFilePath))
            {
                File.Delete(cmdFilePath);
            }
            ZipFile.ExtractToDirectory(download_update_zip, Path.GetDirectoryName(download_update_zip));
            string[] includedUpdateFiles = Directory.GetFiles(Path.GetTempPath() + "\\AudioController");
            File.Delete(download_update_zip);
            using (StreamWriter writer = File.CreateText(cmdFilePath))
            {
                writer.WriteLine($"taskkill /IM {AppDomain.CurrentDomain.FriendlyName} /F");
                writer.WriteLine("timeout /t 1");
                foreach (string file in includedUpdateFiles)
                {
                    writer.WriteLine($"move /Y \"{file}\" \"{AppDomain.CurrentDomain.BaseDirectory}\"");
                }
                writer.WriteLine($"cd /d \"{AppDomain.CurrentDomain.BaseDirectory} \"");
                writer.WriteLine("start AudioController.exe /afterupdate");
                writer.WriteLine("del /f /q %temp%\\UpdateAudioController.cmd");
                writer.Close();
            }
            using (Process proc_install = new Process())
            {
                proc_install.StartInfo.FileName = cmdFilePath;
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
