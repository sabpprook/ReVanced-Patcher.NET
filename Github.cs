using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ReVanced_Patcher.NET
{
    public class Github
    {
        public static Release? GetRelease(string repo)
        {
            try
            {
                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0");
                var json = client.GetStringAsync(repo).Result;
                var release = JsonSerializer.Deserialize<Release>(json);
                return release;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        public class Release
        {
            public string? url { get; set; }
            public string? html_url { get; set; }
            public int id { get; set; }
            public string? name { get; set; }
            public List<Asset>? assets { get; set; }
            public class Asset
            {
                public string? url { get; set; }
                public int id { get; set; }
                public string? node_id { get; set; }
                public string? name { get; set; }
                public int size { get; set; }
                public string? browser_download_url { get; set; }
            }
        }
    }
}
