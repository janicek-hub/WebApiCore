namespace WebApi.Model
{
    public static class VersionDetection
    {
        public static Version GetVersion(string instanceId, DateTimeOffset start, string dllVersion, string status = "")
        {
            var ret = new Version();
            var versionFileDocker = "docker-version.txt";
            if (System.IO.File.Exists(versionFileDocker))
            {
                ret.DockerImageVersion = System.IO.File.ReadAllText(versionFileDocker).Trim();
            }
            var versionFile = "version.json";
            if (System.IO.File.Exists(versionFile))
            {
                try
                {
                    var versionFileContent = System.IO.File.ReadAllText(versionFile);
                    ret = Newtonsoft.Json.JsonConvert.DeserializeObject<Version>(versionFileContent);
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.Message);
                }
            }
            else if (System.IO.File.Exists(versionFile))
            {
                var version = System.IO.File.ReadAllText(versionFile).Trim();
                var versionData = version.Split('|');
                if (versionData.Length == 3)
                {
                    var pos = versionData[0].LastIndexOf('-');
                    if (pos > 0)
                    {
                        ret.ApplicationName = versionData[0].Substring(0, pos - 1).Trim();
                        ret.BuildNumber = versionData[0].Substring(pos + 1).Trim();
                    }
                    ret.DLLVersion = versionData[1].Trim();
                    ret.BuildTime = versionData[2].Trim();
                }
            }
            else
            {
                ret.DLLVersion = dllVersion;
            }
            if (string.IsNullOrEmpty(versionFile))
            {
                ret.DLLVersion = dllVersion;
            }
            ret.InstanceStartedAt = start.ToString("o");
            ret.InstanceIdentifier = instanceId;
            ret.Status = status;
            return ret;
        }
    }
}
