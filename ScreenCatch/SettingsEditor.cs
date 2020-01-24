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
            shortcutPComboBox.SelectedIndex = Settings.Default.Action_PrtSc;
            openEditorPCheckBox.Checked = Settings.Default.OpenEditor_PrtSc;
            shortcutAPComboBox.SelectedIndex = Settings.Default.Action_Alt_PrtSc;
            openEditorAPCheckBox.Checked = Settings.Default.OpenEditor_Alt_PrtSc;
            shortcutSPComboBox.SelectedIndex = Settings.Default.Action_Shift_PrtSc;
            openEditorSPCheckBox.Checked = Settings.Default.OpenEditor_Shift_PrtSc;
            shortcutASPComboBox.SelectedIndex = Settings.Default.Action_Alt_Shift_PrtSc;
            openEditorASPCheckBox.Checked = Settings.Default.OpenEditor_Alt_Shift_PrtSc;

            cursorSurroundingsWidthNumericUD.Value = Settings.Default.CursorAreaW;
            cursorSurroundingsHeightNumericUD.Value = Settings.Default.CursorAreaH;

            notificationCheckBox.Checked = Settings.Default.ShowNotifications;
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
            Settings.Default.Action_PrtSc = shortcutPComboBox.SelectedIndex;
            Settings.Default.Save();
        }

        private void shortcutAPComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            Settings.Default.Action_Alt_PrtSc = shortcutAPComboBox.SelectedIndex;
            Settings.Default.Save();
        }

        private void shortcutSPComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            Settings.Default.Action_Shift_PrtSc = shortcutSPComboBox.SelectedIndex;
            Settings.Default.Save();
        }

        private void shortcutASPComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            Settings.Default.Action_Alt_Shift_PrtSc = shortcutASPComboBox.SelectedIndex;
            Settings.Default.Save();
        }

        private void openEditorPCheckBox_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.OpenEditor_PrtSc = openEditorPCheckBox.Checked;
            Settings.Default.Save();
        }

        private void openEditorAPCheckBox_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.OpenEditor_Alt_PrtSc = openEditorAPCheckBox.Checked;
            Settings.Default.Save();
        }

        private void openEditorSPCheckBox_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.OpenEditor_Shift_PrtSc = openEditorSPCheckBox.Checked;
            Settings.Default.Save();
        }

        private void openEditorASPCheckBox_CheckedChanged(object sender, EventArgs e) {
            Settings.Default.OpenEditor_Alt_Shift_PrtSc = openEditorASPCheckBox.Checked;
            Settings.Default.Save();
        }
    }
}
