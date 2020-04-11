using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkspaceLauncher.Management;

namespace WorkspaceLauncher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            WorkspaceManager wm = new WorkspaceManager();

            bool workspaceToLaunch = false;
            int workspaceID = 0;
            bool openWindow = true;

            if (args.Length > 0)
            {
                workspaceToLaunch = ArgumentParser.LaunchWorkspace(args);
                workspaceID = ArgumentParser.WorkspaceIDToLaunch(args);
                openWindow = ArgumentParser.OpenApplicationWindow(args);
            }
            
            if (workspaceToLaunch)
            {
                wm.LaunchAllAppsOfWorkspace(workspaceID);

                if (openWindow)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainWindow(wm));
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow(wm));
            }
        }
    }
}
