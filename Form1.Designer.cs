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
            this.components = new System.ComponentModel.Container();
            this.btn_CheckReVanced = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_DownloadReVanced = new System.Windows.Forms.Button();
            this.label_CLI_Version = new System.Windows.Forms.Label();
            this.label_Patches_Version = new System.Windows.Forms.Label();
            this.label_Integrations_Version = new System.Windows.Forms.Label();
            this.chkListBox_Patches = new System.Windows.Forms.CheckedListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label_Java_SDK = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_DownloadJDK = new System.Windows.Forms.Button();
            this.textBox_YouTube_APK = new System.Windows.Forms.TextBox();
            this.textBox_Command = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_MakeReVanced = new System.Windows.Forms.Button();
            this.linkLabel_ReVanced = new System.Windows.Forms.LinkLabel();
            this.linkLabel_YouTube_APK = new System.Windows.Forms.LinkLabel();
            this.linkLabel_VancedMicroG = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_CheckReVanced
            // 
            this.btn_CheckReVanced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CheckReVanced.Location = new System.Drawing.Point(612, 12);
            this.btn_CheckReVanced.Name = "btn_CheckReVanced";
            this.btn_CheckReVanced.Size = new System.Drawing.Size(160, 40);
            this.btn_CheckReVanced.TabIndex = 0;
            this.btn_CheckReVanced.Text = "Check ReVanced";
            this.btn_CheckReVanced.UseVisualStyleBackColor = true;
            this.btn_CheckReVanced.Click += new System.EventHandler(this.btn_CheckReVanced_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "revanced-cli:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "revanced-patches:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "revanced-integrations:";
            // 
            // btn_DownloadReVanced
            // 
            this.btn_DownloadReVanced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DownloadReVanced.Enabled = false;
            this.btn_DownloadReVanced.Location = new System.Drawing.Point(612, 58);
            this.btn_DownloadReVanced.Name = "btn_DownloadReVanced";
            this.btn_DownloadReVanced.Size = new System.Drawing.Size(160, 40);
            this.btn_DownloadReVanced.TabIndex = 5;
            this.btn_DownloadReVanced.Text = "Download ReVanced";
            this.btn_DownloadReVanced.UseVisualStyleBackColor = true;
            this.btn_DownloadReVanced.Click += new System.EventHandler(this.btn_DownloadReVanced_Click);
            // 
            // label_CLI_Version
            // 
            this.label_CLI_Version.AutoSize = true;
            this.label_CLI_Version.Location = new System.Drawing.Point(111, 16);
            this.label_CLI_Version.Margin = new System.Windows.Forms.Padding(6);
            this.label_CLI_Version.Name = "label_CLI_Version";
            this.label_CLI_Version.Size = new System.Drawing.Size(0, 17);
            this.label_CLI_Version.TabIndex = 6;
            // 
            // label_Patches_Version
            // 
            this.label_Patches_Version.AutoSize = true;
            this.label_Patches_Version.Location = new System.Drawing.Point(146, 45);
            this.label_Patches_Version.Margin = new System.Windows.Forms.Padding(6);
            this.label_Patches_Version.Name = "label_Patches_Version";
            this.label_Patches_Version.Size = new System.Drawing.Size(0, 17);
            this.label_Patches_Version.TabIndex = 7;
            // 
            // label_Integrations_Version
            // 
            this.label_Integrations_Version.AutoSize = true;
            this.label_Integrations_Version.Location = new System.Drawing.Point(172, 74);
            this.label_Integrations_Version.Margin = new System.Windows.Forms.Padding(6);
            this.label_Integrations_Version.Name = "label_Integrations_Version";
            this.label_Integrations_Version.Size = new System.Drawing.Size(0, 17);
            this.label_Integrations_Version.TabIndex = 8;
            // 
            // chkListBox_Patches
            // 
            this.chkListBox_Patches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkListBox_Patches.FormattingEnabled = true;
            this.chkListBox_Patches.Location = new System.Drawing.Point(12, 134);
            this.chkListBox_Patches.Name = "chkListBox_Patches";
            this.chkListBox_Patches.Size = new System.Drawing.Size(270, 365);
            this.chkListBox_Patches.TabIndex = 9;
            this.chkListBox_Patches.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListBox_Patches_ItemCheck);
            this.chkListBox_Patches.SelectedIndexChanged += new System.EventHandler(this.chkListBox_Patches_SelectedIndexChanged);
            this.chkListBox_Patches.MouseLeave += new System.EventHandler(this.chkListBox_Patches_MouseLeave);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1000;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 1000;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 1000;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // label_Java_SDK
            // 
            this.label_Java_SDK.AutoSize = true;
            this.label_Java_SDK.Location = new System.Drawing.Point(92, 102);
            this.label_Java_SDK.Margin = new System.Windows.Forms.Padding(6);
            this.label_Java_SDK.Name = "label_Java_SDK";
            this.label_Java_SDK.Size = new System.Drawing.Size(0, 17);
            this.label_Java_SDK.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Java SDK:";
            // 
            // btn_DownloadJDK
            // 
            this.btn_DownloadJDK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DownloadJDK.Enabled = false;
            this.btn_DownloadJDK.Location = new System.Drawing.Point(612, 104);
            this.btn_DownloadJDK.Name = "btn_DownloadJDK";
            this.btn_DownloadJDK.Size = new System.Drawing.Size(160, 40);
            this.btn_DownloadJDK.TabIndex = 12;
            this.btn_DownloadJDK.Text = "Download Java SDK";
            this.btn_DownloadJDK.UseVisualStyleBackColor = true;
            this.btn_DownloadJDK.Click += new System.EventHandler(this.btn_DownloadJDK_Click);
            // 
            // textBox_YouTube_APK
            // 
            this.textBox_YouTube_APK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_YouTube_APK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox_YouTube_APK.Location = new System.Drawing.Point(288, 157);
            this.textBox_YouTube_APK.Name = "textBox_YouTube_APK";
            this.textBox_YouTube_APK.ReadOnly = true;
            this.textBox_YouTube_APK.Size = new System.Drawing.Size(484, 24);
            this.textBox_YouTube_APK.TabIndex = 14;
            this.textBox_YouTube_APK.TabStop = false;
            this.textBox_YouTube_APK.Click += new System.EventHandler(this.textBox_YouTube_APK_Click);
            // 
            // textBox_Command
            // 
            this.textBox_Command.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Command.Location = new System.Drawing.Point(288, 220);
            this.textBox_Command.Multiline = true;
            this.textBox_Command.Name = "textBox_Command";
            this.textBox_Command.Size = new System.Drawing.Size(484, 120);
            this.textBox_Command.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Command:";
            // 
            // btn_MakeReVanced
            // 
            this.btn_MakeReVanced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MakeReVanced.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MakeReVanced.Location = new System.Drawing.Point(572, 399);
            this.btn_MakeReVanced.Name = "btn_MakeReVanced";
            this.btn_MakeReVanced.Size = new System.Drawing.Size(200, 100);
            this.btn_MakeReVanced.TabIndex = 17;
            this.btn_MakeReVanced.Text = "ReVanced";
            this.btn_MakeReVanced.UseVisualStyleBackColor = true;
            this.btn_MakeReVanced.Click += new System.EventHandler(this.btn_MakeReVanced_Click);
            // 
            // linkLabel_ReVanced
            // 
            this.linkLabel_ReVanced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel_ReVanced.AutoSize = true;
            this.linkLabel_ReVanced.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel_ReVanced.Location = new System.Drawing.Point(288, 459);
            this.linkLabel_ReVanced.Margin = new System.Windows.Forms.Padding(3);
            this.linkLabel_ReVanced.Name = "linkLabel_ReVanced";
            this.linkLabel_ReVanced.Size = new System.Drawing.Size(116, 17);
            this.linkLabel_ReVanced.TabIndex = 18;
            this.linkLabel_ReVanced.TabStop = true;
            this.linkLabel_ReVanced.Text = "Github: ReVanced";
            this.linkLabel_ReVanced.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ReVanced_LinkClicked);
            // 
            // linkLabel_YouTube_APK
            // 
            this.linkLabel_YouTube_APK.AutoSize = true;
            this.linkLabel_YouTube_APK.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel_YouTube_APK.Location = new System.Drawing.Point(288, 134);
            this.linkLabel_YouTube_APK.Name = "linkLabel_YouTube_APK";
            this.linkLabel_YouTube_APK.Size = new System.Drawing.Size(93, 17);
            this.linkLabel_YouTube_APK.TabIndex = 19;
            this.linkLabel_YouTube_APK.TabStop = true;
            this.linkLabel_YouTube_APK.Text = "YouTube APK:";
            this.linkLabel_YouTube_APK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_YouTube_APK_LinkClicked);
            // 
            // linkLabel_VancedMicroG
            // 
            this.linkLabel_VancedMicroG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel_VancedMicroG.AutoSize = true;
            this.linkLabel_VancedMicroG.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkLabel_VancedMicroG.Location = new System.Drawing.Point(288, 482);
            this.linkLabel_VancedMicroG.Margin = new System.Windows.Forms.Padding(3);
            this.linkLabel_VancedMicroG.Name = "linkLabel_VancedMicroG";
            this.linkLabel_VancedMicroG.Size = new System.Drawing.Size(146, 17);
            this.linkLabel_VancedMicroG.TabIndex = 20;
            this.linkLabel_VancedMicroG.TabStop = true;
            this.linkLabel_VancedMicroG.Text = "Github: VancedMicroG";
            this.linkLabel_VancedMicroG.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_VancedMicroG_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.linkLabel_VancedMicroG);
            this.Controls.Add(this.linkLabel_YouTube_APK);
            this.Controls.Add(this.linkLabel_ReVanced);
            this.Controls.Add(this.btn_MakeReVanced);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Command);
            this.Controls.Add(this.textBox_YouTube_APK);
            this.Controls.Add(this.btn_DownloadJDK);
            this.Controls.Add(this.label_Java_SDK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkListBox_Patches);
            this.Controls.Add(this.label_Integrations_Version);
            this.Controls.Add(this.label_Patches_Version);
            this.Controls.Add(this.label_CLI_Version);
            this.Controls.Add(this.btn_DownloadReVanced);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CheckReVanced);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReVanced Patcher.NET";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}