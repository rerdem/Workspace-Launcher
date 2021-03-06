﻿using System;
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
            DialogResult result = MessageBox.Show("You are about to delete the current workspace. This action cannot be undone. Do you wish to proceed?",
                                     "Confirm Workspace Deletion!",
                                     MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                wm.RemoveCurrentWorkspace();
            }
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

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            wm.LaunchAllAppsOfCurrentWorkspace();
        }

        private void ShortcutButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Shortcut|*.lnk";
            saveFileDialog.Title = "Create a Shortcut";
            saveFileDialog.ShowDialog();

            if (!string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                bool shortcutOpenWindow = false;

                DialogResult result = MessageBox.Show("Do you want Workspace Launcher to open after using the shortcut?",
                                     "Shortcut Window Mode",
                                     MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    shortcutOpenWindow = true;
                }

                ShortcutCreator.CreateShortcut(saveFileDialog.FileName, wm.CurrentWorkspace, shortcutOpenWindow);
            }
        }
    }
}
