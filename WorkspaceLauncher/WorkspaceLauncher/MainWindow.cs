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
            wm.WorkspaceListModified += new EventHandler(wm_WorkspaceListModified);
            wm.CurrentWorkspaceChanged += new EventHandler(wm_CurrentWorkspaceChanged);
            wm.CurrentApplicationListModified += new EventHandler(wm_CurrentApplicationListModified);

            InitializeComponent();

            RefreshAllContent();

        }

        private void RefreshAllContent()
        {
            RefreshWorkspaceComboBox();
            RefreshCurrentWorkspaceNameBox();
            RefreshAppListPanel();
        }

        private void RefreshWorkspaceComboBox()
        {
            WorkspaceComboBox.SelectedIndexChanged -= new EventHandler(WorkspaceComboBox_SelectedIndexChanged);

            WorkspaceComboBox.ComboBox.DataSource = null;
            WorkspaceComboBox.ComboBox.DataSource = wm.Workspaces;
            WorkspaceComboBox.ComboBox.DisplayMember = "Name";

            WorkspaceComboBox.SelectedIndexChanged += new EventHandler(WorkspaceComboBox_SelectedIndexChanged);

            WorkspaceComboBox.ComboBox.SelectedIndex = wm.Workspaces.IndexOf(wm.CurrentWorkspace);
        }

        private void RefreshAppListPanel()
        {
            foreach (ApplicationEntryControl c in AppListPanel.Controls)
            {
                c.DeletionRequested -= new EventHandler<ApplicationEntryEventArgs>(aec_DeletionRequested);
                c.Dispose();
            }

            AppListPanel.Controls.Clear();

            foreach(ApplicationEntry entry in wm.CurrentWorkspace.ApplicationEntries)
            {
                ApplicationEntryControl control = new ApplicationEntryControl(entry);
                control.DeletionRequested += new EventHandler<ApplicationEntryEventArgs>(aec_DeletionRequested);
                AppListPanel.Controls.Add(control);
            }
        }

        private void RefreshCurrentWorkspaceNameBox()
        {
            CurrentWorkspaceNameBox.DataBindings.Clear();
            CurrentWorkspaceNameBox.DataBindings.Add("Text", wm.CurrentWorkspace, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void AddApplicationButton_Click(object sender, EventArgs e)
        {
            wm.AddEntryToCurrentWorspace();
        }

        private void NewWorkspaceButton_Click(object sender, EventArgs e)
        {
            wm.AddWorkspace();
        }

        private void DeleteCurrentWorkspaceButton_Click(object sender, EventArgs e)
        {
            wm.RemoveCurrentWorkspace();
        }

        private void WorkspaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Workspace selectedWorkspace = WorkspaceComboBox.SelectedItem as Workspace;
            if (selectedWorkspace!=null)
            {
                wm.CurrentWorkspaceID = selectedWorkspace.ID;
            }
        }

        private void aec_DeletionRequested(object sender, ApplicationEntryEventArgs e)
        {
            wm.RemoveEntryFromCurrentWorkspace(e.Entry.ID);
        }

        private void wm_WorkspaceListModified(object sender, EventArgs e)
        {
            RefreshWorkspaceComboBox();
        }

        private void wm_CurrentApplicationListModified(object sender, EventArgs e)
        {
            RefreshAppListPanel();
        }

        private void wm_CurrentWorkspaceChanged(object sender, EventArgs e)
        {
            RefreshCurrentWorkspaceNameBox();
            RefreshAppListPanel();
        }
    }
}
