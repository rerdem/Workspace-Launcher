using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkspaceLauncher.Data;
using System.Xml.Serialization.Configuration;

namespace WorkspaceLauncher
{
    public partial class ApplicationEntryControl : UserControl
    {
        public event EventHandler<ApplicationEntryEventArgs> DeletionRequested;

        private ApplicationEntry Entry;

        public ApplicationEntryControl(ApplicationEntry entry)
        {
            Entry = entry;

            InitializeComponent();
            
            CreateDataBindings();
        }

        private void CreateDataBindings()
        {
            NameBox.DataBindings.Add("Text", Entry, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            PathValueLabel.DataBindings.Add("Text", Entry, "Path", false, DataSourceUpdateMode.OnPropertyChanged);
            ParameterBox.DataBindings.Add("Text", Entry, "Parameters", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void PathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Select an application to launch...";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                PathValueLabel.Text = openFile.FileName;
                PathToolTip.SetToolTip(PathValueLabel, openFile.FileName);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ApplicationEntryEventArgs args = new ApplicationEntryEventArgs();
            args.Entry = Entry;
            OnDeletionRequested(args);
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            Entry.StartApplication();
        }

        protected virtual void OnDeletionRequested(ApplicationEntryEventArgs e)
        {
            EventHandler<ApplicationEntryEventArgs> handler = DeletionRequested;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
