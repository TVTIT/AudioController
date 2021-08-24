using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
using System.IO;

namespace AudioController
{
    class Setting
    {
        private static IniFile settings = new IniFile("settings.ini");
        private static KeysConverter kc = new KeysConverter();
        public static void Load(bool isStartup, out bool ckStartup, out Keys PP, out Keys Prev, out Keys Next, out Keys Volume_Mute, out Keys Volume_Down, out Keys Volume_Up)
        {
            if (!File.Exists("settings.ini"))
                CreateSettingsFile();
            if (!isStartup)
            {
                CreateStartupTask(settings.Read("RunOnStartup") == "1");
            }
            ckStartup = settings.Read("RunOnStartup") == "1";
            PP = (Keys)int.Parse(settings.Read("KeyPPCode"));
            Prev = (Keys)int.Parse(settings.Read("KeyPrevCode"));
            Next = (Keys)int.Parse(settings.Read("KeyNextCode"));
            Volume_Mute = (Keys)int.Parse(settings.Read("KeyVlMuteCode"));
            Volume_Down = (Keys)int.Parse(settings.Read("KeyVlDownCode"));
            Volume_Up = (Keys)int.Parse(settings.Read("KeyVlUpCode"));
        }

        public static void Write(bool ckStartup, Keys PP, Keys Prev, Keys Next, Keys Volume_Mute, Keys Volume_Down, Keys Volume_Up)
        {
            settings.Write("RunOnStartup", (ckStartup) ? "1" : "0");
            settings.Write("KeyPPCode", Convert.ToString((int)PP));
            settings.Write("KeyPrevCode", Convert.ToString((int)Prev));
            settings.Write("KeyNextCode", Convert.ToString((int)Next));
            settings.Write("KeyVlMuteCode", Convert.ToString((int)Volume_Mute));
            settings.Write("KeyVlDownCode", Convert.ToString((int)Volume_Down));
            settings.Write("KeyVlUpCode", Convert.ToString((int)Volume_Up));
        }

        private static void CreateSettingsFile()
        {
            settings.Write("RunOnStartup", "0");
            settings.Write("KeyPPCode", "0");
            settings.Write("KeyPrevCode", "0");
            settings.Write("KeyNextCode", "0");
            settings.Write("KeyVlMuteCode", "0");
            settings.Write("KeyVlDownCode", "0");
            settings.Write("KeyVlUpCode", "0");
        }

        private static void CreateStartupTask(bool startup)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (startup)
                rk.SetValue("AudioController", Application.ExecutablePath);
            else
                rk.DeleteValue("AudioController", false); 
        }
    }
}
