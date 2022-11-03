using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReVanced_Patcher.NET
{
    internal class Java
    {
        public static string JavaExe { get; set; } = string.Empty;
        private static string OpenJDK { get; } = "https://aka.ms/download-jdk/microsoft-jdk-17.0.5-windows-x64.zip";

        public static bool CheckVersion()
        {
            var jdkDir = Directory.GetDirectories(Environment.CurrentDirectory, "jdk*");
            foreach (var dir in jdkDir.Append(""))
            {
                var exe = "java.exe";

                if (!string.IsNullOrEmpty(dir))
                    exe = Path.Join(dir, "\\bin\\java.exe");

                if (!File.Exists(exe))
                    continue;

                var result = ProcessOutput(exe, "--version");
                if (result.output.Contains("OpenJDK") && result.output.Contains("Microsoft"))
                {
                    JavaExe = exe.Replace(Environment.CurrentDirectory + "\\", "");
                }
            }
            return string.IsNullOrEmpty(JavaExe);
        }

        public static void DownloadOpenJDK()
        {
            var client = new HttpClient();
            var bytes = client.GetByteArrayAsync(OpenJDK).Result;
            File.WriteAllBytes("jdk.zip", bytes);
            ZipFile.ExtractToDirectory("jdk.zip", Environment.CurrentDirectory);
            File.Delete("jdk.zip");
            CheckVersion();
        }

        private static (string output, string error) ProcessOutput(string FileName, string Arguments)
        {
            try
            {
                var p = Process.Start(new ProcessStartInfo
                {
                    FileName = FileName,
                    Arguments = Arguments,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                });
                p!.WaitForExit();
                var output = p.StandardOutput.ReadToEnd();
                var error = p.StandardError.ReadToEnd();
                return (output, error);
            }
            catch (Exception)
            {
                return (string.Empty, string.Empty);
            }
        }
    }
}
