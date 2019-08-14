using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ScreenCatch {

    public sealed class HotkeyCatcher : NativeWindow {

        private const int WM_HOTKEY = 0x0312;
        private const int WM_DESTROY = 0x0002;

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private readonly List<int> ids = new List<int>();

        public delegate void HotkeyDelegate(int id);
        public event HotkeyDelegate HotkeyPressed;

        public HotkeyCatcher() {
            CreateHandle(new CreateParams());
            Application.ApplicationExit += Application_ApplicationExit;
        }

        public void RegisterHotkey(int id, int modifiers, int vlc) {
            if (RegisterHotKey(Handle, id, modifiers, vlc)) ids.Add(id);
        }

        private void Application_ApplicationExit(object sender, EventArgs e) => DestroyHandle();

        protected override void WndProc(ref Message m) {
            switch (m.Msg) {
                case WM_HOTKEY:
                    HotkeyPressed?.Invoke(m.WParam.ToInt32());
                    break;
                case WM_DESTROY: // fires when "Application.Exit();" is called
                    foreach (var id in ids) UnregisterHotKey(Handle, id);
                    break;
            }
            base.WndProc(ref m);
        }
    }
}