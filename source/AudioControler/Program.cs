using System;
using System.Windows.Forms;

namespace AudioController
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length >= 1)
            {
                if (args[0] == "/afterupdate")
                    MessageBox.Show("Cập nhật lên phiên bản " + Updates.CurrentVer().ToString() + " thành công!", "Audio Controller Updates", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Application.Run(new frmSetting());
        }
    }
}
