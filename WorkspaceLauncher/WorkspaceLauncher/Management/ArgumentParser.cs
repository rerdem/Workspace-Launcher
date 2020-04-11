using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WorkspaceLauncher.Management
{
    public class ArgumentParser
    {
        public static bool LaunchWorkspace(string[] args)
        {
            return args.Any(s => Regex.IsMatch(s, "^--id=(\\d+)"));
        }

        public static int WorkspaceIDToLaunch(string[] args)
        {
            Regex expression = new Regex("^--id=(\\d+)");
            if (args.Any(s => expression.IsMatch(s)))
            {
                foreach (string argument in args.Where(s => expression.IsMatch(s)))
                {
                    Match m = expression.Match(argument);
                    if (m.Success)
                    {
                        int number;
                        bool parseSuccess = Int32.TryParse(m.Groups[1].Captures[0].ToString(), out number);
                        if (parseSuccess)
                        {
                            return number;
                        }
                    }
                }
            }
            
            return 0;
        }

        public static bool OpenApplicationWindow(string[] args)
        {
            return !args.Contains("--no-window");
        }
    }
}
