using System;
using System.Windows.Forms;
using ScreenCatch.Properties;

namespace ScreenCatch {

    public partial class SettingsEditor : Form {

        private readonly object[] actions = { "Capture Active Window", "Capture Active Screen", "Capture All Screens", "Capture Cursor Surroundings", "Do Nothing" };

        public SettingsEditor() {
            InitializeComponent();
            shortcutPComboBox.Items.AddRange(actions);
            shortcutAPComboBox.Items.AddRange(actions);
            shortcutSPComboBox.Items.AddRange(actions);
            shortcutASPComboBox.Items.AddRange(actions);
            UpdateSettings();
        }

        public void UpdateSettings() {
            notificationCheckBox.Checked = Settings.Default.ShowNotifications;
            cursorSurroundingsWidthNumericUD.Value = Settings.Default.CursorAreaW;
            cursorSurroundingsHeightNumericUD.Value = Settings.Default.CursorAreaH;
            shortcutPComboBox.SelectedIndex = Settings.Default.Shurtcut_PrtSc;
            shortcutAPComboBox.SelectedIndex = Settings.Default.Shurtcut_Alt_PrtSc;
            shortcutSPComboBox.SelectedIndex = Settings.Default.Shurtcut_Shift_PrtSc;
            shortcutASPComboBox.SelectedIndex = Settings.Default.Shurtcut_Alt_Shift_PrtSc;
        }

        private void SettingsEditor_Load(object sender, EventArgs e) { }

        private void SettingsEditor_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                Hide();
            }
        }

        private void notificationCheckBox_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.ShowNotifications = notificationCheckBox.Checked;
            Settings.Default.Save();
        }

        private void cursorSurroundingsWidthNumericUD_ValueChanged(object sender, EventArgs e) {
            Settings.Default.CursorAreaW = (int)cursorSurroundingsWidthNumericUD.Value;
            Settings.Default.Save();
        }

        private void cursorSurroundingsHeightNumericUD_ValueChanged(object sender, EventArgs e) {
            Settings.Default.CursorAreaH = (int)cursorSurroundingsHeightNumericUD.Value;
            Settings.Default.Save();
        }

        private void shortcutPComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            Settings.Default.Shurtcut_PrtSc = shortcutPComboBox.SelectedIndex;
            Settings.Default.Save();
        }

        private void shortcutAPComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            Settings.Default.Shurtcut_Alt_PrtSc = shortcutAPComboBox.SelectedIndex;
            Settings.Default.Save();
        }

        private void shortcutSPComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            Settings.Default.Shurtcut_Shift_PrtSc = shortcutSPComboBox.SelectedIndex;
            Settings.Default.Save();
        }

        private void shortcutASPComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            Settings.Default.Shurtcut_Alt_Shift_PrtSc = shortcutASPComboBox.SelectedIndex;
            Settings.Default.Save();
        }
    }
}
