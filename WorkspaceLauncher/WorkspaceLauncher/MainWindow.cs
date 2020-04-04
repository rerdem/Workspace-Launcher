using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            WorkspaceComboBox.ComboBox.DataSource = wm.Workspaces;
            WorkspaceComboBox.ComboBox.DisplayMember = "Name";
        }

        private void RefreshWorkspaceComboBox()
        {
            WorkspaceComboBox.ComboBox.DataSource = null;
            WorkspaceComboBox.ComboBox.DataSource = wm.Workspaces;
        }

        private void RefreshAppListPanel()
        {
            //TO DO
        }

        private void RefreshCurrentWorkspaceNameBox()
        {
            //TO DO
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
        }
    }
}
