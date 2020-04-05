using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkspaceLauncher.Data;
using WorkspaceLauncher.Management;

namespace WorkspaceLauncher
{
    public partial class MainWindow : Form
    {
        private WorkspaceManager wm;
        public MainWindow(WorkspaceManager manager)
        {
            wm = manager;

            InitializeComponent();

            RefreshWorkspaceComboBox();
            WorkspaceComboBox.ComboBox.DisplayMember = "Name";
            WorkspaceComboBox.ComboBox.SelectedIndex = wm.Workspaces.IndexOf(wm.GetCurrentWorkspace);
        }

        private void RefreshWorkspaceComboBox()
        {
            WorkspaceComboBox.SelectedIndexChanged -= new EventHandler(WorkspaceComboBox_SelectedIndexChanged);

            WorkspaceComboBox.ComboBox.DataSource = null;
            WorkspaceComboBox.ComboBox.DataSource = wm.Workspaces;

            WorkspaceComboBox.SelectedIndexChanged += new EventHandler(WorkspaceComboBox_SelectedIndexChanged);
        }

        private void RefreshAppListPanel()
        {
            //TO DO
            foreach (ApplicationEntryControl c in AppListPanel.Controls)
            {
                c.Dispose();
            }

            AppListPanel.Controls.Clear();

            foreach(ApplicationEntry entry in wm.GetCurrentWorkspace.ApplicationEntries)
            {
                AppListPanel.Controls.Add(new ApplicationEntryControl(entry));
            }
        }

        private void RefreshCurrentWorkspaceNameBox()
        {
            //TO DO
            CurrentWorkspaceNameBox.DataBindings.Clear();
            CurrentWorkspaceNameBox.DataBindings.Add("Text", wm.GetCurrentWorkspace, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void AddApplicationButton_Click(object sender, EventArgs e)
        {
            //TO DO
        }

        private void NewWorkspaceButton_Click(object sender, EventArgs e)
        {
            //TO DO
        }

        private void DeleteCurrentWorkspaceButton_Click(object sender, EventArgs e)
        {
            //TO DO
        }

        private void WorkspaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //TO DO
            Workspace selectedWorkspace = WorkspaceComboBox.SelectedItem as Workspace;
            if (selectedWorkspace!=null)
            {
                wm.CurrentWorkspaceID = selectedWorkspace.ID;
            }

            RefreshCurrentWorkspaceNameBox();
            RefreshAppListPanel();
        }
    }
}
