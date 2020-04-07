using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkspaceLauncher.Management
{
    public class ProcessStarter
    {
        public static void StartProcess(string path, string parameters)
        {
            using (System.Diagnostics.Process pProcess = new System.Diagnostics.Process())
            {
                pProcess.StartInfo.FileName = path;
                pProcess.StartInfo.Arguments = parameters;
                //pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                pProcess.Start();
            }
        }
    }
}
