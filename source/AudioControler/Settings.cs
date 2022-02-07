using Microsoft.Win32;
using System;
using System.Windows.Forms;
namespace AudioController.Properties {
    
    
    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
    internal sealed partial class Settings {

        //public Settings() {
        //    // // To add event handlers for saving and changing settings, uncomment the lines below:
        //    //
        //    // this.SettingChanging += this.SettingChangingEventHandler;
        //    //
        //    // this.SettingsSaving += this.SettingsSavingEventHandler;
        //    //
        //}

        //private void SettingChangingEventHandler(object sender, System.Configuration.SettingChangingEventArgs e)
        //{
        //    // Add code to handle the SettingChangingEvent event here.
        //}

        //private void SettingsSavingEventHandler(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    // Add code to handle the SettingsSaving event here.
        //}

        private KeysConverter kc = new KeysConverter();

        public static void Load(bool isStartup, out bool ckStartup, out Keys PP, out Keys Prev, out Keys Next, out Keys Volume_Mute, out Keys Volume_Down, out Keys Volume_Up, out bool autoUpdates)
        {
            if (!isStartup)
            {
                CreateStartupTask(Convert.ToBoolean(Default["RunOnStartup"]));
            }
            ckStartup = Default.RunOnStartup;
            PP = (Keys) Default.KeyPPCode;
            Prev = (Keys)Default.KeyPrevCode;
            Next = (Keys) Default.KeyNextCode;
            Volume_Mute = (Keys)Default.KeyVlMuteCode;
            Volume_Down = (Keys) Default.KeyVlDownCode;
            Volume_Up = (Keys)Default.KeyVlUpCode;
            autoUpdates = Default.AutoUpdates;
        }
         
        public static void Write(bool ckStartup, Keys PP, Keys Prev, Keys Next, Keys Volume_Mute, Keys Volume_Down, Keys Volume_Up, bool autoUpdates)
        {
            Default.RunOnStartup = ckStartup;
            Default.KeyPPCode = (int)PP;
            Default.KeyPrevCode = (int)Prev;
            Default.KeyNextCode = (int)Next;
            Default.KeyVlMuteCode = (int)Volume_Mute;
            Default.KeyVlDownCode = (int)Volume_Down;
            Default.KeyVlUpCode = (int) Volume_Up;
            Default.AutoUpdates = autoUpdates;
            Default.Save();
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
