namespace ScreenCatch {
    partial class SettingsEditor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsEditor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cursorSurroundingsWidthNumericUD = new System.Windows.Forms.NumericUpDown();
            this.cursorSurroundingsHeightNumericUD = new System.Windows.Forms.NumericUpDown();
            this.notificationCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openEditorASPCheckBox = new System.Windows.Forms.CheckBox();
            this.openEditorSPCheckBox = new System.Windows.Forms.CheckBox();
            this.openEditorAPCheckBox = new System.Windows.Forms.CheckBox();
            this.openEditorPCheckBox = new System.Windows.Forms.CheckBox();
            this.shortcutSPComboBox = new System.Windows.Forms.ComboBox();
            this.shortcutASPComboBox = new System.Windows.Forms.ComboBox();
            this.shortcutAPComboBox = new System.Windows.Forms.ComboBox();
            this.shortcutPComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.cursorSurroundingsWidthNumericUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursorSurroundingsHeightNumericUD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height:";
            // 
            // cursorSurroundingsWidthNumericUD
            // 
            this.cursorSurroundingsWidthNumericUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cursorSurroundingsWidthNumericUD.Location = new System.Drawing.Point(67, 22);
            this.cursorSurroundingsWidthNumericUD.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.cursorSurroundingsWidthNumericUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cursorSurroundingsWidthNumericUD.Name = "cursorSurroundingsWidthNumericUD";
            this.cursorSurroundingsWidthNumericUD.Size = new System.Drawing.Size(180, 26);
            this.cursorSurroundingsWidthNumericUD.TabIndex = 3;
            this.cursorSurroundingsWidthNumericUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cursorSurroundingsWidthNumericUD.ValueChanged += new System.EventHandler(this.cursorSurroundingsWidthNumericUD_ValueChanged);
            // 
            // cursorSurroundingsHeightNumericUD
            // 
            this.cursorSurroundingsHeightNumericUD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cursorSurroundingsHeightNumericUD.Location = new System.Drawing.Point(314, 22);
            this.cursorSurroundingsHeightNumericUD.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.cursorSurroundingsHeightNumericUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cursorSurroundingsHeightNumericUD.Name = "cursorSurroundingsHeightNumericUD";
            this.cursorSurroundingsHeightNumericUD.Size = new System.Drawing.Size(180, 26);
            this.cursorSurroundingsHeightNumericUD.TabIndex = 4;
            this.cursorSurroundingsHeightNumericUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cursorSurroundingsHeightNumericUD.ValueChanged += new System.EventHandler(this.cursorSurroundingsHeightNumericUD_ValueChanged);
            // 
            // notificationCheckBox
            // 
            this.notificationCheckBox.AutoSize = true;
            this.notificationCheckBox.Location = new System.Drawing.Point(6, 25);
            this.notificationCheckBox.Name = "notificationCheckBox";
            this.notificationCheckBox.Size = new System.Drawing.Size(141, 22);
            this.notificationCheckBox.TabIndex = 5;
            this.notificationCheckBox.Text = "Show Notifications";
            this.notificationCheckBox.UseVisualStyleBackColor = true;
            this.notificationCheckBox.CheckedChanged += new System.EventHandler(this.notificationCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.openEditorASPCheckBox);
            this.groupBox1.Controls.Add(this.openEditorSPCheckBox);
            this.groupBox1.Controls.Add(this.openEditorAPCheckBox);
            this.groupBox1.Controls.Add(this.openEditorPCheckBox);
            this.groupBox1.Controls.Add(this.shortcutSPComboBox);
            this.groupBox1.Controls.Add(this.shortcutASPComboBox);
            this.groupBox1.Controls.Add(this.shortcutAPComboBox);
            this.groupBox1.Controls.Add(this.shortcutPComboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 154);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // openEditorASPCheckBox
            // 
            this.openEditorASPCheckBox.AutoSize = true;
            this.openEditorASPCheckBox.Location = new System.Drawing.Point(393, 123);
            this.openEditorASPCheckBox.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.openEditorASPCheckBox.Name = "openEditorASPCheckBox";
            this.openEditorASPCheckBox.Size = new System.Drawing.Size(101, 22);
            this.openEditorASPCheckBox.TabIndex = 16;
            this.openEditorASPCheckBox.Text = "Open Editor";
            this.openEditorASPCheckBox.UseVisualStyleBackColor = true;
            this.openEditorASPCheckBox.CheckedChanged += new System.EventHandler(this.openEditorASPCheckBox_CheckedChanged);
            // 
            // openEditorSPCheckBox
            // 
            this.openEditorSPCheckBox.AutoSize = true;
            this.openEditorSPCheckBox.Location = new System.Drawing.Point(393, 91);
            this.openEditorSPCheckBox.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.openEditorSPCheckBox.Name = "openEditorSPCheckBox";
            this.openEditorSPCheckBox.Size = new System.Drawing.Size(101, 22);
            this.openEditorSPCheckBox.TabIndex = 15;
            this.openEditorSPCheckBox.Text = "Open Editor";
            this.openEditorSPCheckBox.UseVisualStyleBackColor = true;
            this.openEditorSPCheckBox.CheckedChanged += new System.EventHandler(this.openEditorSPCheckBox_CheckedChanged);
            // 
            // openEditorAPCheckBox
            // 
            this.openEditorAPCheckBox.AutoSize = true;
            this.openEditorAPCheckBox.Location = new System.Drawing.Point(393, 59);
            this.openEditorAPCheckBox.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.openEditorAPCheckBox.Name = "openEditorAPCheckBox";
            this.openEditorAPCheckBox.Size = new System.Drawing.Size(101, 22);
            this.openEditorAPCheckBox.TabIndex = 14;
            this.openEditorAPCheckBox.Text = "Open Editor";
            this.openEditorAPCheckBox.UseVisualStyleBackColor = true;
            this.openEditorAPCheckBox.CheckedChanged += new System.EventHandler(this.openEditorAPCheckBox_CheckedChanged);
            // 
            // openEditorPCheckBox
            // 
            this.openEditorPCheckBox.AutoSize = true;
            this.openEditorPCheckBox.Location = new System.Drawing.Point(393, 27);
            this.openEditorPCheckBox.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.openEditorPCheckBox.Name = "openEditorPCheckBox";
            this.openEditorPCheckBox.Size = new System.Drawing.Size(101, 22);
            this.openEditorPCheckBox.TabIndex = 7;
            this.openEditorPCheckBox.Text = "Open Editor";
            this.openEditorPCheckBox.UseVisualStyleBackColor = true;
            this.openEditorPCheckBox.CheckedChanged += new System.EventHandler(this.openEditorPCheckBox_CheckedChanged);
            // 
            // shortcutSPComboBox
            // 
            this.shortcutSPComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shortcutSPComboBox.FormattingEnabled = true;
            this.shortcutSPComboBox.Location = new System.Drawing.Point(172, 89);
            this.shortcutSPComboBox.Name = "shortcutSPComboBox";
            this.shortcutSPComboBox.Size = new System.Drawing.Size(207, 26);
            this.shortcutSPComboBox.TabIndex = 13;
            this.shortcutSPComboBox.SelectedIndexChanged += new System.EventHandler(this.shortcutSPComboBox_SelectedIndexChanged);
            // 
            // shortcutASPComboBox
            // 
            this.shortcutASPComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shortcutASPComboBox.FormattingEnabled = true;
            this.shortcutASPComboBox.Location = new System.Drawing.Point(172, 121);
            this.shortcutASPComboBox.Name = "shortcutASPComboBox";
            this.shortcutASPComboBox.Size = new System.Drawing.Size(207, 26);
            this.shortcutASPComboBox.TabIndex = 12;
            this.shortcutASPComboBox.SelectedIndexChanged += new System.EventHandler(this.shortcutASPComboBox_SelectedIndexChanged);
            // 
            // shortcutAPComboBox
            // 
            this.shortcutAPComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shortcutAPComboBox.FormattingEnabled = true;
            this.shortcutAPComboBox.Location = new System.Drawing.Point(172, 57);
            this.shortcutAPComboBox.Name = "shortcutAPComboBox";
            this.shortcutAPComboBox.Size = new System.Drawing.Size(207, 26);
            this.shortcutAPComboBox.TabIndex = 11;
            this.shortcutAPComboBox.SelectedIndexChanged += new System.EventHandler(this.shortcutAPComboBox_SelectedIndexChanged);
            // 
            // shortcutPComboBox
            // 
            this.shortcutPComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shortcutPComboBox.FormattingEnabled = true;
            this.shortcutPComboBox.Location = new System.Drawing.Point(172, 25);
            this.shortcutPComboBox.Name = "shortcutPComboBox";
            this.shortcutPComboBox.Size = new System.Drawing.Size(207, 26);
            this.shortcutPComboBox.TabIndex = 10;
            this.shortcutPComboBox.SelectedIndexChanged += new System.EventHandler(this.shortcutPComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Shift + Alt + Print Screen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Shift + Print Screen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Alt + Print Screen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Print Screen";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.notificationCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 54);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cursorSurroundingsHeightNumericUD);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cursorSurroundingsWidthNumericUD);
            this.groupBox3.Location = new System.Drawing.Point(12, 169);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(500, 55);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cursor Surroundings";
            // 
            // SettingsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 293);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsEditor";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsEditor_FormClosing);
            this.Load += new System.EventHandler(this.SettingsEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cursorSurroundingsWidthNumericUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursorSurroundingsHeightNumericUD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown cursorSurroundingsWidthNumericUD;
        private System.Windows.Forms.NumericUpDown cursorSurroundingsHeightNumericUD;
        private System.Windows.Forms.CheckBox notificationCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox shortcutSPComboBox;
        private System.Windows.Forms.ComboBox shortcutASPComboBox;
        private System.Windows.Forms.ComboBox shortcutAPComboBox;
        private System.Windows.Forms.ComboBox shortcutPComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox openEditorPCheckBox;
        private System.Windows.Forms.CheckBox openEditorASPCheckBox;
        private System.Windows.Forms.CheckBox openEditorSPCheckBox;
        private System.Windows.Forms.CheckBox openEditorAPCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
