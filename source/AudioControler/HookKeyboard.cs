using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AudioController
{
    class HookKeyboard
    {
        public static Keys PP; 
        public static Keys Prev;
        public static Keys Next;
        public static Keys Volume_Mute; 
        public static Keys Volume_Down; 
        public static Keys Volume_Up; 

        public static bool is_binding = false;
        public static Keys KeyBinding { get; set; }

        /// <summary>
        /// Keybd_event: https://docs.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-keybd_event
        /// </summary>
        #region Keybd Event
        private const int VK_MEDIA_NEXT_TRACK = 0xB0;
        private const int VK_MEDIA_PLAY_PAUSE = 0xB3;
        private const int VK_MEDIA_PREV_TRACK = 0xB1;
        private const int VK_MEDIA_STOP = 0xB2;
        private const int VK_VOLUME_MUTE = 0xAD;
        private const int VK_VOLUME_DOWN = 0xAE;
        private const int VK_VOLUME_UP = 0xAF;

        [DllImport("user32.dll")]
        private static extern void keybd_event(byte virtualKey, byte scanCode, uint flags, IntPtr extraInfo);
        #endregion

        /// <summary>
        /// Low level keyboard hook: https://docs.microsoft.com/en-us/archive/blogs/toub/low-level-keyboard-hook-in-c
        /// </summary>
        #region Hook Keyboard
        private const int KEYEVENTF_EXTENTEDKEY = 1;
        private const int KEYEVENTF_KEYUP = 0;
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        private static int vkCode;
        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(
            int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(
            int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                vkCode = Marshal.ReadInt32(lParam);
                if (is_binding && !string.IsNullOrEmpty(new KeysConverter().ConvertToString((Keys)vkCode)) && (Keys)vkCode != Keys.None)
                {
                    KeyBinding = (Keys)vkCode;
                    is_binding = false;
                }
                else if ((Keys)vkCode != Keys.None)
                {
                    if ((Keys)vkCode == PP && PP != Keys.None)
                        keybd_event(VK_MEDIA_PLAY_PAUSE, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
                    else if ((Keys)vkCode == Prev && Prev != Keys.None)
                        keybd_event(VK_MEDIA_PREV_TRACK, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
                    else if ((Keys)vkCode == Next && Next != Keys.None)
                        keybd_event(VK_MEDIA_NEXT_TRACK, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
                    else if ((Keys)vkCode == Volume_Mute && Volume_Mute != Keys.None)
                        keybd_event(VK_VOLUME_MUTE, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
                    else if ((Keys)vkCode == Volume_Down && Volume_Down != Keys.None)
                        keybd_event(VK_VOLUME_DOWN, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
                    else if ((Keys)vkCode == Volume_Up && Volume_Up != Keys.None)
                        keybd_event(VK_VOLUME_UP, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }


        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        #endregion

        public static void Run()
        {
            _hookID = SetHook(_proc);
            Application.Run();
            UnhookWindowsHookEx(_hookID);
        }

        public static void PauseMusic()
        {
            keybd_event(VK_MEDIA_STOP, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);
        }
    }
}
