namespace ReVanced_Patcher.NET
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            btn_CheckReVanced = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_DownloadReVanced = new Button();
            label_CLI_Version = new Label();
            label_Patches_Version = new Label();
            label_Integrations_Version = new Label();
            chkListBox_Patches = new CheckedListBox();
            toolTip1 = new ToolTip(components);
            label_Java_SDK = new Label();
            label4 = new Label();
            btn_DownloadJDK = new Button();
            textBox_YouTube_APK = new TextBox();
            textBox_Command = new TextBox();
            label5 = new Label();
            btn_MakeReVanced = new Button();
            linkLabel_ReVanced = new LinkLabel();
            linkLabel_YouTube_APK = new LinkLabel();
            linkLabel_VancedMicroG = new LinkLabel();
            linkLabel_VancedMicroG2 = new LinkLabel();
            comboBox_Variant = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btn_CheckReVanced
            // 
            btn_CheckReVanced.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_CheckReVanced.Location = new Point(612, 12);
            btn_CheckReVanced.Name = "btn_CheckReVanced";
            btn_CheckReVanced.Size = new Size(160, 40);
            btn_CheckReVanced.TabIndex = 0;
            btn_CheckReVanced.Text = "Check ReVanced";
            btn_CheckReVanced.UseVisualStyleBackColor = true;
            btn_CheckReVanced.Click += btn_CheckReVanced_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 46);
            label1.Margin = new Padding(6);
            label1.Name = "label1";
            label1.Size = new Size(84, 17);
            label1.TabIndex = 1;
            label1.Text = "revanced-cli:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 75);
            label2.Margin = new Padding(6);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 2;
            label2.Text = "revanced-patches:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 104);
            label3.Margin = new Padding(6);
            label3.Name = "label3";
            label3.Size = new Size(145, 17);
            label3.TabIndex = 3;
            label3.Text = "revanced-integrations:";
            // 
            // btn_DownloadReVanced
            // 
            btn_DownloadReVanced.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_DownloadReVanced.Enabled = false;
            btn_DownloadReVanced.Location = new Point(612, 58);
            btn_DownloadReVanced.Name = "btn_DownloadReVanced";
            btn_DownloadReVanced.Size = new Size(160, 40);
            btn_DownloadReVanced.TabIndex = 5;
            btn_DownloadReVanced.Text = "Download ReVanced";
            btn_DownloadReVanced.UseVisualStyleBackColor = true;
            btn_DownloadReVanced.Click += btn_DownloadReVanced_Click;
            // 
            // label_CLI_Version
            // 
            label_CLI_Version.AutoSize = true;
            label_CLI_Version.Location = new Point(111, 47);
            label_CLI_Version.Margin = new Padding(6);
            label_CLI_Version.Name = "label_CLI_Version";
            label_CLI_Version.Size = new Size(0, 17);
            label_CLI_Version.TabIndex = 6;
            // 
            // label_Patches_Version
            // 
            label_Patches_Version.AutoSize = true;
            label_Patches_Version.Location = new Point(146, 76);
            label_Patches_Version.Margin = new Padding(6);
            label_Patches_Version.Name = "label_Patches_Version";
            label_Patches_Version.Size = new Size(0, 17);
            label_Patches_Version.TabIndex = 7;
            // 
            // label_Integrations_Version
            // 
            label_Integrations_Version.AutoSize = true;
            label_Integrations_Version.Location = new Point(172, 105);
            label_Integrations_Version.Margin = new Padding(6);
            label_Integrations_Version.Name = "label_Integrations_Version";
            label_Integrations_Version.Size = new Size(0, 17);
            label_Integrations_Version.TabIndex = 8;
            // 
            // chkListBox_Patches
            // 
            chkListBox_Patches.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            chkListBox_Patches.FormattingEnabled = true;
            chkListBox_Patches.Location = new Point(12, 172);
            chkListBox_Patches.Name = "chkListBox_Patches";
            chkListBox_Patches.Size = new Size(270, 327);
            chkListBox_Patches.TabIndex = 9;
            chkListBox_Patches.ItemCheck += chkListBox_Patches_ItemCheck;
            chkListBox_Patches.SelectedIndexChanged += chkListBox_Patches_SelectedIndexChanged;
            chkListBox_Patches.MouseLeave += chkListBox_Patches_MouseLeave;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 1000;
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 1000;
            toolTip1.IsBalloon = true;
            toolTip1.ReshowDelay = 1000;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // label_Java_SDK
            // 
            label_Java_SDK.AutoSize = true;
            label_Java_SDK.Location = new Point(92, 133);
            label_Java_SDK.Margin = new Padding(6);
            label_Java_SDK.Name = "label_Java_SDK";
            label_Java_SDK.Size = new Size(0, 17);
            label_Java_SDK.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 133);
            label4.Margin = new Padding(6);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 10;
            label4.Text = "Java SDK:";
            // 
            // btn_DownloadJDK
            // 
            btn_DownloadJDK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_DownloadJDK.Enabled = false;
            btn_DownloadJDK.Location = new Point(612, 104);
            btn_DownloadJDK.Name = "btn_DownloadJDK";
            btn_DownloadJDK.Size = new Size(160, 40);
            btn_DownloadJDK.TabIndex = 12;
            btn_DownloadJDK.Text = "Download Java SDK";
            btn_DownloadJDK.UseVisualStyleBackColor = true;
            btn_DownloadJDK.Click += btn_DownloadJDK_Click;
            // 
            // textBox_YouTube_APK
            // 
            textBox_YouTube_APK.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_YouTube_APK.Cursor = Cursors.Hand;
            textBox_YouTube_APK.Location = new Point(288, 195);
            textBox_YouTube_APK.Name = "textBox_YouTube_APK";
            textBox_YouTube_APK.ReadOnly = true;
            textBox_YouTube_APK.Size = new Size(484, 24);
            textBox_YouTube_APK.TabIndex = 14;
            textBox_YouTube_APK.TabStop = false;
            textBox_YouTube_APK.Click += textBox_YouTube_APK_Click;
            // 
            // textBox_Command
            // 
            textBox_Command.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_Command.Location = new Point(288, 258);
            textBox_Command.Multiline = true;
            textBox_Command.Name = "textBox_Command";
            textBox_Command.Size = new Size(484, 120);
            textBox_Command.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(288, 235);
            label5.Margin = new Padding(3);
            label5.Name = "label5";
            label5.Size = new Size(75, 17);
            label5.TabIndex = 16;
            label5.Text = "Command:";
            // 
            // btn_MakeReVanced
            // 
            btn_MakeReVanced.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_MakeReVanced.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_MakeReVanced.Location = new Point(572, 399);
            btn_MakeReVanced.Name = "btn_MakeReVanced";
            btn_MakeReVanced.Size = new Size(200, 100);
            btn_MakeReVanced.TabIndex = 17;
            btn_MakeReVanced.Text = "ReVanced";
            btn_MakeReVanced.UseVisualStyleBackColor = true;
            btn_MakeReVanced.Click += btn_MakeReVanced_Click;
            // 
            // linkLabel_ReVanced
            // 
            linkLabel_ReVanced.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            linkLabel_ReVanced.AutoSize = true;
            linkLabel_ReVanced.LinkColor = Color.LightSeaGreen;
            linkLabel_ReVanced.Location = new Point(288, 436);
            linkLabel_ReVanced.Margin = new Padding(3);
            linkLabel_ReVanced.Name = "linkLabel_ReVanced";
            linkLabel_ReVanced.Size = new Size(116, 17);
            linkLabel_ReVanced.TabIndex = 18;
            linkLabel_ReVanced.TabStop = true;
            linkLabel_ReVanced.Text = "Github: ReVanced";
            linkLabel_ReVanced.LinkClicked += linkLabel_ReVanced_LinkClicked;
            // 
            // linkLabel_YouTube_APK
            // 
            linkLabel_YouTube_APK.AutoSize = true;
            linkLabel_YouTube_APK.LinkColor = Color.Red;
            linkLabel_YouTube_APK.Location = new Point(288, 172);
            linkLabel_YouTube_APK.Name = "linkLabel_YouTube_APK";
            linkLabel_YouTube_APK.Size = new Size(93, 17);
            linkLabel_YouTube_APK.TabIndex = 19;
            linkLabel_YouTube_APK.TabStop = true;
            linkLabel_YouTube_APK.Text = "YouTube APK:";
            linkLabel_YouTube_APK.LinkClicked += linkLabel_YouTube_APK_LinkClicked;
            // 
            // linkLabel_VancedMicroG
            // 
            linkLabel_VancedMicroG.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            linkLabel_VancedMicroG.AutoSize = true;
            linkLabel_VancedMicroG.LinkColor = Color.LightSeaGreen;
            linkLabel_VancedMicroG.Location = new Point(288, 459);
            linkLabel_VancedMicroG.Margin = new Padding(3);
            linkLabel_VancedMicroG.Name = "linkLabel_VancedMicroG";
            linkLabel_VancedMicroG.Size = new Size(190, 17);
            linkLabel_VancedMicroG.TabIndex = 20;
            linkLabel_VancedMicroG.TabStop = true;
            linkLabel_VancedMicroG.Text = "Github: MicroG (TeamVanced)";
            linkLabel_VancedMicroG.LinkClicked += linkLabel_VancedMicroG_LinkClicked;
            // 
            // linkLabel_VancedMicroG2
            // 
            linkLabel_VancedMicroG2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            linkLabel_VancedMicroG2.AutoSize = true;
            linkLabel_VancedMicroG2.LinkColor = Color.DeepSkyBlue;
            linkLabel_VancedMicroG2.Location = new Point(288, 483);
            linkLabel_VancedMicroG2.Margin = new Padding(3);
            linkLabel_VancedMicroG2.Name = "linkLabel_VancedMicroG2";
            linkLabel_VancedMicroG2.Size = new Size(162, 17);
            linkLabel_VancedMicroG2.TabIndex = 21;
            linkLabel_VancedMicroG2.TabStop = true;
            linkLabel_VancedMicroG2.Text = "Github: MicroG (inotia00)";
            linkLabel_VancedMicroG2.LinkClicked += linkLabel_VancedMicroG2_LinkClicked;
            // 
            // comboBox_Variant
            // 
            comboBox_Variant.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Variant.FormattingEnabled = true;
            comboBox_Variant.Items.AddRange(new object[] { "revanced", "inotia00" });
            comboBox_Variant.Location = new Point(76, 12);
            comboBox_Variant.Name = "comboBox_Variant";
            comboBox_Variant.Size = new Size(120, 25);
            comboBox_Variant.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 16);
            label6.Name = "label6";
            label6.Size = new Size(55, 17);
            label6.TabIndex = 23;
            label6.Text = "Variant:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 511);
            Controls.Add(label6);
            Controls.Add(comboBox_Variant);
            Controls.Add(linkLabel_VancedMicroG2);
            Controls.Add(linkLabel_VancedMicroG);
            Controls.Add(linkLabel_YouTube_APK);
            Controls.Add(linkLabel_ReVanced);
            Controls.Add(btn_MakeReVanced);
            Controls.Add(label5);
            Controls.Add(textBox_Command);
            Controls.Add(textBox_YouTube_APK);
            Controls.Add(btn_DownloadJDK);
            Controls.Add(label_Java_SDK);
            Controls.Add(label4);
            Controls.Add(chkListBox_Patches);
            Controls.Add(label_Integrations_Version);
            Controls.Add(label_Patches_Version);
            Controls.Add(label_CLI_Version);
            Controls.Add(btn_DownloadReVanced);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_CheckReVanced);
            Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReVanced Patcher.NET";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_CheckReVanced;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_DownloadReVanced;
        private Label label_CLI_Version;
        private Label label_Patches_Version;
        private Label label_Integrations_Version;
        private CheckedListBox chkListBox_Patches;
        private ToolTip toolTip1;
        private Label label_Java_SDK;
        private Label label4;
        private Button btn_DownloadJDK;
        private TextBox textBox_YouTube_APK;
        private TextBox textBox_Command;
        private Label label5;
        private Button btn_MakeReVanced;
        private LinkLabel linkLabel_ReVanced;
        private LinkLabel linkLabel_YouTube_APK;
        private LinkLabel linkLabel_VancedMicroG;
        private LinkLabel linkLabel_VancedMicroG2;
        private ComboBox comboBox_Variant;
        private Label label6;
    }
}