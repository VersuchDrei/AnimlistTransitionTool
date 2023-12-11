namespace Animlist_Transition_Tool
{
    partial class AnimlistTransitionTool
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimlistTransitionTool));
            FileViewBox = new ListBox();
            MenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            animlistToolStripMenuItem = new ToolStripMenuItem();
            fNISToolStripMenuItem = new ToolStripMenuItem();
            outputToolStripMenuItem = new ToolStripMenuItem();
            pathToolStripMenuItem = new ToolStripMenuItem();
            LaunchButton = new Button();
            ModPrefixInput = new RichTextBox();
            ModNameInput = new RichTextBox();
            ModAuthorInput = new RichTextBox();
            ModLinkInput = new RichTextBox();
            label1 = new Label();
            label7 = new Label();
            label9 = new Label();
            label8 = new Label();
            FileProgressBar = new ProgressBar();
            label2 = new Label();
            OutputPathDisplay = new RichTextBox();
            MenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // FileViewBox
            // 
            FileViewBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            FileViewBox.BackColor = Color.FromArgb(30, 30, 30);
            FileViewBox.BorderStyle = BorderStyle.None;
            FileViewBox.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FileViewBox.ForeColor = SystemColors.Control;
            FileViewBox.FormattingEnabled = true;
            FileViewBox.ItemHeight = 19;
            FileViewBox.Location = new Point(12, 38);
            FileViewBox.Name = "FileViewBox";
            FileViewBox.SelectionMode = SelectionMode.MultiExtended;
            FileViewBox.Size = new Size(1018, 988);
            FileViewBox.TabIndex = 1;
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = Color.FromArgb(30, 30, 30);
            MenuStrip.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.RenderMode = ToolStripRenderMode.System;
            MenuStrip.Size = new Size(1904, 27);
            MenuStrip.TabIndex = 2;
            MenuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, outputToolStripMenuItem });
            fileToolStripMenuItem.ForeColor = SystemColors.Control;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(45, 23);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { animlistToolStripMenuItem });
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(127, 24);
            loadToolStripMenuItem.Text = "Load";
            // 
            // animlistToolStripMenuItem
            // 
            animlistToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fNISToolStripMenuItem });
            animlistToolStripMenuItem.Name = "animlistToolStripMenuItem";
            animlistToolStripMenuItem.Size = new Size(133, 24);
            animlistToolStripMenuItem.Text = "Animlist";
            // 
            // fNISToolStripMenuItem
            // 
            fNISToolStripMenuItem.Name = "fNISToolStripMenuItem";
            fNISToolStripMenuItem.Size = new Size(110, 24);
            fNISToolStripMenuItem.Text = "FNIS";
            fNISToolStripMenuItem.Click += fNISToolStripMenuItem_Click;
            // 
            // outputToolStripMenuItem
            // 
            outputToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pathToolStripMenuItem });
            outputToolStripMenuItem.Name = "outputToolStripMenuItem";
            outputToolStripMenuItem.Size = new Size(127, 24);
            outputToolStripMenuItem.Text = "Output";
            // 
            // pathToolStripMenuItem
            // 
            pathToolStripMenuItem.Name = "pathToolStripMenuItem";
            pathToolStripMenuItem.Size = new Size(110, 24);
            pathToolStripMenuItem.Text = "Path";
            pathToolStripMenuItem.Click += pathToolStripMenuItem_Click;
            // 
            // LaunchButton
            // 
            LaunchButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LaunchButton.BackColor = SystemColors.ScrollBar;
            LaunchButton.BackgroundImageLayout = ImageLayout.Stretch;
            LaunchButton.FlatStyle = FlatStyle.Popup;
            LaunchButton.Location = new Point(1831, 940);
            LaunchButton.Name = "LaunchButton";
            LaunchButton.Size = new Size(61, 63);
            LaunchButton.TabIndex = 3;
            LaunchButton.UseVisualStyleBackColor = false;
            LaunchButton.Click += LaunchButton_Click;
            // 
            // ModPrefixInput
            // 
            ModPrefixInput.BackColor = Color.FromArgb(30, 30, 30);
            ModPrefixInput.BorderStyle = BorderStyle.None;
            ModPrefixInput.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModPrefixInput.ForeColor = SystemColors.Control;
            ModPrefixInput.Location = new Point(1128, 38);
            ModPrefixInput.MaxLength = 6;
            ModPrefixInput.Multiline = false;
            ModPrefixInput.Name = "ModPrefixInput";
            ModPrefixInput.Size = new Size(86, 22);
            ModPrefixInput.TabIndex = 6;
            ModPrefixInput.Text = "";
            ModPrefixInput.KeyPress += ValidateKeyPress;
            // 
            // ModNameInput
            // 
            ModNameInput.BackColor = Color.FromArgb(30, 30, 30);
            ModNameInput.BorderStyle = BorderStyle.None;
            ModNameInput.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModNameInput.ForeColor = SystemColors.Control;
            ModNameInput.Location = new Point(1128, 66);
            ModNameInput.Multiline = false;
            ModNameInput.Name = "ModNameInput";
            ModNameInput.Size = new Size(251, 22);
            ModNameInput.TabIndex = 8;
            ModNameInput.Text = "";
            ModNameInput.KeyPress += ValidateKeyPress;
            // 
            // ModAuthorInput
            // 
            ModAuthorInput.BackColor = Color.FromArgb(30, 30, 30);
            ModAuthorInput.BorderStyle = BorderStyle.None;
            ModAuthorInput.DetectUrls = false;
            ModAuthorInput.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModAuthorInput.ForeColor = SystemColors.Control;
            ModAuthorInput.Location = new Point(1128, 94);
            ModAuthorInput.Multiline = false;
            ModAuthorInput.Name = "ModAuthorInput";
            ModAuthorInput.Size = new Size(251, 22);
            ModAuthorInput.TabIndex = 22;
            ModAuthorInput.Text = "";
            ModAuthorInput.KeyPress += ValidateKeyPress;
            // 
            // ModLinkInput
            // 
            ModLinkInput.BackColor = Color.FromArgb(30, 30, 30);
            ModLinkInput.BorderStyle = BorderStyle.None;
            ModLinkInput.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ModLinkInput.ForeColor = SystemColors.Control;
            ModLinkInput.Location = new Point(1128, 122);
            ModLinkInput.Multiline = false;
            ModLinkInput.Name = "ModLinkInput";
            ModLinkInput.Size = new Size(251, 22);
            ModLinkInput.TabIndex = 23;
            ModLinkInput.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(1042, 41);
            label1.Name = "label1";
            label1.Size = new Size(81, 19);
            label1.TabIndex = 24;
            label1.Text = "Mod Prefix";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(1042, 66);
            label7.Name = "label7";
            label7.Size = new Size(83, 19);
            label7.TabIndex = 25;
            label7.Text = "Mod Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(1036, 94);
            label9.Name = "label9";
            label9.Size = new Size(89, 19);
            label9.TabIndex = 26;
            label9.Text = "Mod Author";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(1054, 122);
            label8.Name = "label8";
            label8.Size = new Size(71, 19);
            label8.TabIndex = 27;
            label8.Text = "Mod Link";
            // 
            // FileProgressBar
            // 
            FileProgressBar.BackColor = Color.FromArgb(30, 30, 30);
            FileProgressBar.Dock = DockStyle.Bottom;
            FileProgressBar.Location = new Point(0, 1018);
            FileProgressBar.Name = "FileProgressBar";
            FileProgressBar.Size = new Size(1904, 23);
            FileProgressBar.Style = ProgressBarStyle.Continuous;
            FileProgressBar.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(1030, 165);
            label2.Name = "label2";
            label2.Size = new Size(93, 19);
            label2.TabIndex = 29;
            label2.Text = "Output Path";
            // 
            // OutputPathDisplay
            // 
            OutputPathDisplay.BackColor = Color.FromArgb(30, 30, 30);
            OutputPathDisplay.BorderStyle = BorderStyle.None;
            OutputPathDisplay.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            OutputPathDisplay.ForeColor = SystemColors.Control;
            OutputPathDisplay.Location = new Point(1128, 165);
            OutputPathDisplay.Multiline = false;
            OutputPathDisplay.Name = "OutputPathDisplay";
            OutputPathDisplay.ReadOnly = true;
            OutputPathDisplay.Size = new Size(475, 22);
            OutputPathDisplay.TabIndex = 30;
            OutputPathDisplay.Text = "";
            // 
            // AnimlistTransitionTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(1904, 1041);
            Controls.Add(OutputPathDisplay);
            Controls.Add(label2);
            Controls.Add(FileProgressBar);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(ModLinkInput);
            Controls.Add(ModAuthorInput);
            Controls.Add(ModNameInput);
            Controls.Add(ModPrefixInput);
            Controls.Add(LaunchButton);
            Controls.Add(FileViewBox);
            Controls.Add(MenuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuStrip;
            Name = "AnimlistTransitionTool";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Animlist Transition Tool";
            WindowState = FormWindowState.Maximized;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox FileViewBox;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem animlistToolStripMenuItem;
        private ToolStripMenuItem fNISToolStripMenuItem;
        private Button LaunchButton;
        private ToolStripMenuItem outputToolStripMenuItem;
        private ToolStripMenuItem pathToolStripMenuItem;
        private RichTextBox ModPrefixInput;
        private RichTextBox ModNameInput;
        private RichTextBox ModAuthorInput;
        private RichTextBox ModLinkInput;
        private Label label1;
        private Label label7;
        private Label label9;
        private Label label8;
        private ProgressBar FileProgressBar;
        private Label label2;
        private RichTextBox OutputPathDisplay;
    }
}