using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ReVanced_Patcher.NET
{
    internal class ReVanced
    {
        private static string CLI_API { get; } = "https://api.github.com/repos/{0}/revanced-cli/releases/latest";
        private static string Patches_API { get; } = "https://api.github.com/repos/{0}/revanced-patches/releases/latest";
        private static string Integrations_API { get; } = "https://api.github.com/repos/{0}/revanced-integrations/releases/latest";
        public static string? Variant { get; set; } = "revanced";
        public static string? CLI { get; set; } = string.Empty;
        public static string? CLI_Version { get; set; }
        public static string? Patches { get; set; } = string.Empty;
        public static string? Patches_Json { get; set; } = string.Empty;
        public static string? Patches_Version { get; set; }
        public static string? Integrations { get; set; } = string.Empty;
        public static string? Integrations_Version { get; set; }
        public static bool UseGithub { get; set; }

        public static void CheckCLI()
        {
            if (UseGithub)
            {
                var release = Github.GetRelease(string.Format(CLI_API, Variant));
                if (release?.assets?.Count > 0)
                {
                    CLI = release.assets[0].browser_download_url;
                    CLI_Version = "Github:" + release.name;
                }
                return;
            }

            var search = Directory.GetFiles(Environment.CurrentDirectory, "revanced-cli*.jar");
            if (search.Length > 0) CLI = search[0];
        }

        public static void CheckPatches()
        {
            if (UseGithub)
            {
                var release = Github.GetRelease(string.Format(Patches_API, Variant));
                if (release?.assets?.Count > 0)
                {
                    Patches = release.assets.Where(x => x.browser_download_url!.Contains(".jar")).First().browser_download_url;
                    Patches_Json = release.assets.Where(x => x.browser_download_url!.Contains(".json")).First().browser_download_url;
                    Patches_Version = "Github:" + release.name;
                }
                return;
            }

            var search = Directory.GetFiles(Environment.CurrentDirectory, "revanced-patches*.jar");
            if (search.Length > 0) Patches = search[0];

            search = Directory.GetFiles(Environment.CurrentDirectory, "patches.json");
            if (search.Length > 0) Patches_Json = search[0];
        }

        public static void CheckIntegrations()
        {
            if (UseGithub)
            {
                var release = Github.GetRelease(string.Format(Integrations_API, Variant));
                if (release?.assets?.Count > 0)
                {
                    Integrations = release.assets[0].browser_download_url;
                    Integrations_Version = "Github:" + release.name;
                }
                return;
            }

            var search = Directory.GetFiles(Environment.CurrentDirectory, "revanced-integrations*.apk");
            if (search.Length > 0) Integrations = search[0];
        }

        public static void DownloadFile(string? url, string? filename)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0");
            var bytes = client.GetByteArrayAsync(url).Result;
            File.WriteAllBytes(filename!, bytes);
        }

        public class Patch
        {
            public string name { get; set; } = string.Empty;
            public string? description { get; set; }
            public string? version { get; set; }
            public bool excluded { get; set; }
            public bool deprecated { get; set; }
            public List<Option>? options { get; set; }
            public List<string>? dependencies { get; set; }
            public List<CompatiblePackage>? compatiblePackages { get; set; }
            public bool isChecked
            {
                get
                {
                    if (name.Contains("-ads")) return true;
                    if (name.Contains("-revancify")) return true;
                    if (name.StartsWith("custom-")) return false;
                    if (name.StartsWith("disable-")) return false;
                    if (name.StartsWith("hide-")) return false;
                    return true;
                }
            }

            public override string ToString()
            {
                return string.IsNullOrEmpty(name) ? "null" : name;
            }

            public class Option
            {
                public string? key { get; set; }
                public string? title { get; set; }
                public string? description { get; set; }
                public bool required { get; set; }
                public object? choices { get; set; }
            }

            public class CompatiblePackage
            {
                public string? name { get; set; }
                public List<string>? versions { get; set; }
            }
        }
    }
}
