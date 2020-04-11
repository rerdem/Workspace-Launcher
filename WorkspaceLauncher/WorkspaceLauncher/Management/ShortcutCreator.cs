using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using WorkspaceLauncher.Data;

namespace WorkspaceLauncher.Management
{
    public class ShortcutCreator
    {
        public static void CreateShortcut(string path, Workspace workspace, bool openWindow)
        {
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(path);
            shortcut.Description = $"Launch Shortcut for Workspace {workspace.Name}";
            
            //construct argument string
            string arguments = $"--id={workspace.ID}";
            if (!openWindow)
            {
                arguments += " --no-window";
            }

            shortcut.Arguments = arguments;
            shortcut.WorkingDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            shortcut.TargetPath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            shortcut.Save();
        }
    }
}
