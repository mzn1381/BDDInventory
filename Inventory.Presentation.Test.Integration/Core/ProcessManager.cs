using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Academy.AcceptanceTests.Core
{
    public static class ProcessManager
    {
        private class WindowsProcess
        {
            public int ProcessId { get; set; }
            public int Port { get; set; }
            public string Protocol { get; set; }
        }

        public static void KillByPort(int port)
        {
            var processes = GetAllProcesses();
            if (processes.Any(p => p.Port == port))
                Process.GetProcessById(processes.First(p => p.Port == port).ProcessId).Kill();
        }

        public static int? FindProcessIdByPort(int port)
        {
            return GetAllProcesses().FirstOrDefault(a => a.Port == port)?.ProcessId;
        }

        private static List<WindowsProcess> GetAllProcesses()
        {

             var processInfo = new ProcessStartInfo
            {
                FileName = "/usr/local/share/dotnet/dotnet",
                Arguments = "-a -n -o",
                WindowStyle = ProcessWindowStyle.Maximized,
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };
            var t = Process.GetProcesses().Where(c=>c.ProcessName.Contains("Tdd.Peresenta")).ToList();
            // var process = Process.Start(processInfo);
            // var soStream = process.StandardOutput;

            // var output = soStream.ReadToEnd();
            // var processInfo = new ProcessStartInfo
            // {
            //     FileName = "/Users/mzn1381/Program/TddTest/Tdd.Peresentation/Tdd.Peresentation.csproj",
            //     Arguments = "-a -n -o",
            //     WindowStyle = ProcessWindowStyle.Maximized,
            //     UseShellExecute = false,
            //     RedirectStandardInput = true,
            //     RedirectStandardOutput = true,
            //     RedirectStandardError = true
            // };
             var process = Process.Start
             ( new ProcessStartInfo("open","-a '/Users/mzn1381/Program/TddTest/Tdd.Peresentation/Tdd.Peresentation.csproj")
             {UseShellExecute=false,RedirectStandardOutput=true,RedirectStandardInput = true,RedirectStandardError=true});
             var soStream = process.StandardOutput;

             var output = soStream.ReadToEnd();
              if (process.ExitCode != 0)
                  throw new Exception("something broken");

            var lines = Regex.Split(output, "\r\n");
            return CreateProcessFromOutput(lines);
        }

        private static List<WindowsProcess> CreateProcessFromOutput(string[] lines)
        {
            var result = new List<WindowsProcess>();
            foreach (var line in lines)
            {
                if (line.Trim().StartsWith("Proto"))
                    continue;

                var parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var len = parts.Length;
                if (len > 2)
                    result.Add(new WindowsProcess
                    {
                        Protocol = parts[0],
                        Port = int.Parse(parts[1].Split(':').Last()),
                        ProcessId = int.Parse(parts[len - 1])
                    });
            }

            return result;
        }
    }
}
