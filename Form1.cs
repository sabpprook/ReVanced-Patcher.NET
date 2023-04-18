using System;
using System.Diagnostics;
using System.Text.Json;
using System.Windows.Forms;

namespace ReVanced_Patcher.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Variant.SelectedIndex = 0;

            btn_DownloadJDK.Enabled = Java.CheckVersion();
            label_Java_SDK.Text = Java.JavaExe;

            var result = CheckReVanced();
            if (result)
            {
                label_CLI_Version.Text = Path.GetFileName(ReVanced.CLI);
                label_Patches_Version.Text = Path.GetFileName(ReVanced.Patches);
                label_Integrations_Version.Text = Path.GetFileName(ReVanced.Integrations);
                ParsePatches();
            }

            ReVanced.UseGithub = true;
        }

        private bool CheckReVanced()
        {
            ReVanced.CheckCLI();
            ReVanced.CheckPatches();
            ReVanced.CheckIntegrations();

            if (string.IsNullOrEmpty(ReVanced.CLI) ||
                string.IsNullOrEmpty(ReVanced.Patches) ||
                string.IsNullOrEmpty(ReVanced.Integrations) ||
                string.IsNullOrEmpty(ReVanced.Patches_Json))
            {
                return false;
            }

            return true;
        }

        private void ParsePatches()
        {
            var patches_json = Path.GetFileName(ReVanced.Patches_Json);
            if (File.Exists(patches_json))
            {
                var patches = JsonSerializer.Deserialize<List<ReVanced.Patch>>(File.ReadAllText(patches_json));
                if (patches == null) return;
                chkListBox_Patches.Items.Clear();
                foreach (var patch in patches)
                {
                    var package = patch.compatiblePackages?.Where(x => x.name!.EndsWith("com.google.android.youtube")).FirstOrDefault();
                    if (package != null)
                    {
                        chkListBox_Patches.Items.Add(patch, patch.isChecked);
                    }
                }
            }
        }

        private async void btn_CheckReVanced_Click(object sender, EventArgs e)
        {
            ReVanced.Variant = comboBox_Variant.Text;
            label_CLI_Version.Text = label_Patches_Version.Text = label_Integrations_Version.Text = string.Empty;

            btn_CheckReVanced.Enabled = false;
            var result = await Task.Run(() => CheckReVanced());
            btn_CheckReVanced.Enabled = true;

            label_CLI_Version.Text = ReVanced.CLI_Version + " : " + Path.GetFileName(ReVanced.CLI);
            label_Patches_Version.Text = ReVanced.Patches_Version + " : " + Path.GetFileName(ReVanced.Patches);
            label_Integrations_Version.Text = ReVanced.Integrations_Version + " : " + Path.GetFileName(ReVanced.Integrations);

            btn_DownloadReVanced.Enabled = true;
        }

        private async void btn_DownloadReVanced_Click(object sender, EventArgs e)
        {
            btn_DownloadReVanced.Enabled = false;

            label_CLI_Version.Text += "  Downloading...";
            await Task.Run(() => ReVanced.DownloadFile(ReVanced.CLI, Path.GetFileName(ReVanced.CLI)));
            label_CLI_Version.Text = Path.GetFileName(ReVanced.CLI);

            label_Patches_Version.Text += "  Downloading...";
            await Task.Run(() => ReVanced.DownloadFile(ReVanced.Patches, Path.GetFileName(ReVanced.Patches)));
            await Task.Run(() => ReVanced.DownloadFile(ReVanced.Patches_Json, Path.GetFileName(ReVanced.Patches_Json)));
            label_Patches_Version.Text = Path.GetFileName(ReVanced.Patches);

            label_Integrations_Version.Text += "  Downloading...";
            await Task.Run(() => ReVanced.DownloadFile(ReVanced.Integrations, Path.GetFileName(ReVanced.Integrations)));
            label_Integrations_Version.Text = Path.GetFileName(ReVanced.Integrations);

            ParsePatches();
        }

        private async void btn_DownloadJDK_Click(object sender, EventArgs e)
        {
            btn_DownloadJDK.Enabled = false;
            label_Java_SDK.Text = "Downloading...";
            await Task.Run(() => Java.DownloadOpenJDK());

            btn_DownloadJDK.Enabled = Java.CheckVersion();
            label_Java_SDK.Text = Java.JavaExe;
        }

        private void chkListBox_Patches_SelectedIndexChanged(object sender, EventArgs e)
        {
            var patch = (ReVanced.Patch)chkListBox_Patches.SelectedItem;
            if (!string.IsNullOrEmpty(patch.name))
            {
                toolTip1.ToolTipTitle = patch.name;

                var tooltip = string.Empty;
                tooltip = $"\nDescription:\n    {patch.description}\n";

                if (patch.dependencies != null && patch.dependencies.Count > 0)
                {
                    tooltip += "\nDependencies:\n";
                    foreach (var item in patch.dependencies) tooltip += $"    {item}\n";
                }

                var package = patch.compatiblePackages?.Where(x => x.name!.EndsWith("com.google.android.youtube")).FirstOrDefault();
                if (package != null && package.versions != null && package.versions.Count > 0)
                {
                    tooltip += "\nCompatible:\n";
                    foreach (var version in package.versions) tooltip += $"    {version}\n";
                }
                toolTip1.SetToolTip(chkListBox_Patches, tooltip);
            }
        }

        private void textBox_YouTube_APK_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            ofd.InitialDirectory = Environment.CurrentDirectory;
            ofd.Filter = "APK Files|*.apk|All Files|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox_YouTube_APK.Text = ofd.FileName;
                textBox_Command.Text = GenerateCommand();
            }
        }

        private string GenerateCommand()
        {
            var java = Java.JavaExe;
            var cli = Path.GetFileName(ReVanced.CLI);
            var patches = Path.GetFileName(ReVanced.Patches);
            var integrations = Path.GetFileName(ReVanced.Integrations);
            var youtube = textBox_YouTube_APK.Text;

            if (string.IsNullOrEmpty(java) ||
                string.IsNullOrEmpty(cli) ||
                string.IsNullOrEmpty(patches) ||
                string.IsNullOrEmpty(integrations) ||
                string.IsNullOrEmpty(youtube))
                return string.Empty;

            var exclude = new List<string>();
            foreach (ReVanced.Patch patch in chkListBox_Patches.Items)
            {
                if (!chkListBox_Patches.CheckedItems.Contains(patch) && !string.IsNullOrEmpty(patch.name))
                {
                    exclude.Add(patch.name);
                }
            }

            var command = $"{java} -jar {cli} -c -a \"{youtube}\" -b {patches} -m {integrations} -o revanced.apk";
            foreach (var item in exclude) command += $" -e {item}";

            return command;
        }

        private void chkListBox_Patches_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            textBox_Command.Text = GenerateCommand();
        }

        private void chkListBox_Patches_MouseLeave(object sender, EventArgs e)
        {
            textBox_Command.Text = GenerateCommand();
        }

        private void btn_MakeReVanced_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Command.Text)) return;
            var p = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                UseShellExecute = false,
                RedirectStandardInput = true,
                WorkingDirectory = Environment.CurrentDirectory
            });

            if (p == null) return;
            p.StandardInput.WriteLine(textBox_Command.Text);
            p.WaitForExit();
        }


        private void linkLabel_YouTube_APK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.apkmirror.com/apk/google-inc/youtube/youtube-18-05-40-release/") { UseShellExecute = true });
        }

        private void linkLabel_ReVanced_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/revanced") { UseShellExecute = true });
        }

        private void linkLabel_VancedMicroG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/TeamVanced/VancedMicroG/releases") { UseShellExecute = true });
        }

        private void linkLabel_VancedMicroG2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/inotia00/VancedMicroG/releases") { UseShellExecute = true });
        }
    }
}