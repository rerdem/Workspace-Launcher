using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkspaceLauncher.Data
{
    public class ApplicationEntryEventArgs : EventArgs
    {
        public ApplicationEntry Entry { get; set; }
    }
}
