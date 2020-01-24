using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ScreenCatch.Properties;

namespace ScreenCatch {

    internal class SCApplicationContext : ApplicationContext {

        [DllImport("user32.dll")]
        private static extern int GetForegroundWindow();

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;

            public int Width => Right - Left;
            public int Height => Bottom - Top;
            public Size Size => new Size(Width, Height);
            public bool IsZero => Left == 0 && Right == 0 && Top == 0 && Bottom == 0;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);

        [Flags]
        private enum KeyModifier { None = 0, Alt = 1, Control = 2, Shift = 4, WinKey = 8 }

        internal enum CaptureType { Window, Screen, All, Cursor }

        private readonly NotifyIcon trayIcon;
        private readonly string dir;
        private readonly HotkeyCatcher hotkeyCatcher;
        private readonly MenuItem notificationCheck;
        private readonly Timer timer;
        private int notificationCount;
        private readonly SettingsEditor settingsEditor;
        private readonly Func<bool>[] actions;
        private string lastPath;

        public SCApplicationContext() {
            trayIcon = new NotifyIcon {
                Icon = Resources.AppIcon,
                ContextMenu = new ContextMenu(new[] {
                    new MenuItem("Open Directory", OpenDirectory),
                    notificationCheck = new MenuItem("Show Notifications", ToggleNotifications),
                    new MenuItem("Open Settings", OpenSettings),
                    new MenuItem("Exit", Exit)
                }),
                Visible = true
            };
            actions = new Func<bool>[] {
                CaptureActiveWindow,
                CaptureActiveScreen,
                CaptureAll,
                CaptureAroundCursor,
                DoNothing
            };
            lastPath = null;
            trayIcon.BalloonTipClicked += OpenFolderSelectLast;
            notificationCheck.Checked = Settings.Default.ShowNotifications;
            dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "ScreenCatch");
            Directory.CreateDirectory(dir);
            hotkeyCatcher = new HotkeyCatcher();
            hotkeyCatcher.HotkeyPressed += HotkeyPressed;
            hotkeyCatcher.RegisterHotkey(1008, (int)KeyModifier.None, (int)Keys.PrintScreen);
            hotkeyCatcher.RegisterHotkey(1009, (int)KeyModifier.Alt, (int)Keys.PrintScreen);
            hotkeyCatcher.RegisterHotkey(1010, (int)KeyModifier.Shift, (int)Keys.PrintScreen);
            hotkeyCatcher.RegisterHotkey(1011, (int)(KeyModifier.Shift | KeyModifier.Alt), (int)Keys.PrintScreen);
            notificationCount = 0;
            timer = new Timer { Interval = 2000 };
            timer.Tick += TimerTick;
            settingsEditor = new SettingsEditor();
        }

        private bool DoNothing() => false;

        private void HotkeyPressed(int id) {
            try {
                switch (id) {
                    case 1008:
                        // PrintScreen
                        if (actions[Settings.Default.Action_PrtSc]() && Settings.Default.OpenEditor_PrtSc) {
                            OpenEditor(lastPath);
                        }
                        break;
                    case 1009:
                        // ALT + PrintScreen
                        if (actions[Settings.Default.Action_Alt_PrtSc]() && Settings.Default.OpenEditor_Alt_PrtSc) {
                            OpenEditor(lastPath);
                        }
                        break;
                    case 1010:
                        // SHIFT + PrintScreen
                        if (actions[Settings.Default.Action_Shift_PrtSc]() && Settings.Default.OpenEditor_Shift_PrtSc) {
                            OpenEditor(lastPath);
                        }
                        break;
                    case 1011:
                        // ALT + SHIFT + PrintScreen
                        if (actions[Settings.Default.Action_Alt_Shift_PrtSc]() && Settings.Default.OpenEditor_Alt_Shift_PrtSc) {
                            OpenEditor(lastPath);
                        }
                        break;
                }
            } catch (Exception ex) {
                trayIcon.BalloonTipIcon = ToolTipIcon.Error;
                trayIcon.BalloonTipTitle = "Screenshot capture failed.";
                trayIcon.BalloonTipText = $"{ex}";
                trayIcon.ShowBalloonTip(1500);
            }
        }

        private string GetNewSaveFilePath() {
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            var dateTime = DateTime.Now;
            var path = Path.Combine(dir, $"S_{dateTime.Year:D4}-{dateTime.Month:D2}-{dateTime.Day:D2}_{dateTime.Hour:D2}-{dateTime.Minute:D2}-{dateTime.Second:D2}-{dateTime.Millisecond:D4}");
            if (!File.Exists(path + ".png")) return lastPath = path + ".png";
            var i = 2;
            while (File.Exists($"{path}_[{i}].png")) ++i;
            return lastPath = $"{path}_[{i}].png";
        }

        private bool CaptureActiveWindow() {
            var fwnd = (IntPtr)GetForegroundWindow();
            var wndArea = new RECT();
            GetWindowRect(fwnd, ref wndArea);
            if (wndArea.IsZero) return false;
            var bmpScreenshot = new Bitmap(wndArea.Width, wndArea.Height, PixelFormat.Format24bppRgb);
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(wndArea.Left, wndArea.Top, 0, 0, wndArea.Size, CopyPixelOperation.SourceCopy);
            bmpScreenshot.Save(GetNewSaveFilePath(), ImageFormat.Png);
            Notify(CaptureType.Window);
            return true;
        }

        private bool CaptureActiveScreen() {
            var fwnd = (IntPtr)GetForegroundWindow();
            var screenBounds = Screen.FromHandle(fwnd).Bounds;
            var bmpScreenshot = new Bitmap(screenBounds.Width, screenBounds.Height, PixelFormat.Format32bppArgb);
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(screenBounds.X, screenBounds.Y, 0, 0, screenBounds.Size,
                CopyPixelOperation.SourceCopy);
            bmpScreenshot.Save(GetNewSaveFilePath(), ImageFormat.Png);
            Notify(CaptureType.Screen);
            return true;
        }

        private bool CaptureAll() {
            var minX = Screen.AllScreens.Min(s => s.Bounds.Left);
            var maxX = Screen.AllScreens.Max(s => s.Bounds.Right);
            var minY = Screen.AllScreens.Min(s => s.Bounds.Top);
            var maxY = Screen.AllScreens.Max(s => s.Bounds.Bottom);
            var totalWidth = maxX - minX;
            var totalHeight = maxY - minY;
            var bmpScreenshot = new Bitmap(totalWidth, totalHeight, PixelFormat.Format32bppArgb);
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.Clear(Color.Black);
            foreach (var screenBounds in Screen.AllScreens.Select(s => s.Bounds))
                gfxScreenshot.CopyFromScreen(screenBounds.X, screenBounds.Y, screenBounds.X - minX, screenBounds.Y - minY, screenBounds.Size, CopyPixelOperation.SourceCopy);
            bmpScreenshot.Save(GetNewSaveFilePath(), ImageFormat.Png);
            Notify(CaptureType.All);
            return true;
        }

        private bool CaptureAroundCursor() {
            var pos = Cursor.Position;
            var bmpScreenshot = new Bitmap(Settings.Default.CursorAreaW, Settings.Default.CursorAreaH, PixelFormat.Format32bppArgb);
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.Clear(Color.Black);
            int wd2 = Settings.Default.CursorAreaW / 2, hd2 = Settings.Default.CursorAreaH / 2;
            gfxScreenshot.CopyFromScreen(pos.X - wd2, pos.Y - hd2, 0, 0, new Size(Settings.Default.CursorAreaW, Settings.Default.CursorAreaH), CopyPixelOperation.SourceCopy);
            bmpScreenshot.Save(GetNewSaveFilePath(), ImageFormat.Png);
            Notify(CaptureType.Cursor);
            return true;
        }

        private void OpenEditor(string file) {
            Process.Start(new ProcessStartInfo(file) { Verb = "edit" });
        }

        /// <summary>Shows notification to the user</summary>
        /// <param name="type">Currently unused, this may change in the future</param>
        private void Notify(CaptureType type) {
            if (!Settings.Default.ShowNotifications) return;
            ++notificationCount;
            if (notificationCount > 1) {
                trayIcon.ShowBalloonTip(500, "", $"{notificationCount} screenshots captured.", ToolTipIcon.Info);
                timer.Stop();
                timer.Start();
            } else {
                trayIcon.ShowBalloonTip(500, "", "Screenshot captured.", ToolTipIcon.Info);
                timer.Start();
            }
        }

        private void OpenDirectory(object sender, EventArgs e) => Process.Start("explorer", dir);

        private void OpenFolderSelectLast(object sender, EventArgs e) {
            if (lastPath == null) return;
            Process.Start(new ProcessStartInfo {
                FileName = "explorer",
                Arguments = $@"/e, /select, ""{lastPath}"""
            });
        }

        private void OpenSettings(object sender, EventArgs e) {
            if (settingsEditor.Visible)
                settingsEditor.Focus();
            else settingsEditor.Show();
        }

        private void Exit(object sender, EventArgs e) {
            // Hide tray icon, otherwise it will remain shown until mouse hovers over it
            trayIcon.Visible = false;
            Application.Exit();
        }

        private void ToggleNotifications(object sender, EventArgs e) {
            notificationCheck.Checked = Settings.Default.ShowNotifications = !Settings.Default.ShowNotifications;
            Settings.Default.Save();
            settingsEditor.UpdateSettings();
        }

        private void TimerTick(object sender, EventArgs e) {
            notificationCount = 0;
            timer.Stop();
        }
    }
}
