using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkspaceLauncher.Data;

namespace WorkspaceLauncher.Management
{
    public class WorkspaceManager
    {
        public event EventHandler WorkspaceListModified;
        public event EventHandler CurrentWorkspaceChanged;
        public event EventHandler CurrentApplicationListModified;

        public List<Workspace> Workspaces { get; set; }
        public int CurrentWorkspaceID { get { return currentWorkspaceID; }
        set
            {
                currentWorkspaceID = value;
                SaveLastUsedWorkspaceID(currentWorkspaceID);
                SubscribeToCurrentWorkspaceEvents();

                OnCurrentWorkspaceChanged(null);
            }
        }
        public Workspace CurrentWorkspace 
        { 
            get 
            {
                return Workspaces.Where(w => w.ID == CurrentWorkspaceID).First();
            } 
        }

        private SerializationManager sm;
        private int WorkspaceIDCounter;
        private int currentWorkspaceID;

        public WorkspaceManager()
        {
            Workspaces = new List<Workspace>();
            
            sm = new SerializationManager();

            WorkspaceIDCounter = 0;
            
            ImportWorkspaces();
            LoadLastUsedWorkspaceID();
        }

        public void AddWorkspace()
        {
            AddWorkspaceWithoutEvent();

            OnWorkspaceListModified(null);
        }

        private void AddWorkspaceWithoutEvent()
        {
            Workspaces.Add(new Workspace(WorkspaceIDCounter, $"Workspace_{DateTime.Now.ToString("yyyy-MM-dd_HHmmss")}"));
            CurrentWorkspaceID = Workspaces.Last().ID;
            WorkspaceIDCounter++;
            
            SaveWorkspaces();
        }

        public void RemoveCurrentWorkspace()
        {
            int indexToDelete = Workspaces.IndexOf(CurrentWorkspace);
            Workspaces.RemoveAt(indexToDelete);

            if (indexToDelete > 0)
            {
                CurrentWorkspaceID = Workspaces.ElementAt(indexToDelete - 1).ID;
            }
            else
            {
                if (Workspaces.Count <= 0)
                {
                    AddWorkspaceWithoutEvent();
                    CurrentWorkspaceID = Workspaces.ElementAt(0).ID;
                }
                else
                {
                    CurrentWorkspaceID = Workspaces.ElementAt(indexToDelete).ID;
                }
            }

            SaveWorkspaces();

            OnWorkspaceListModified(null);
        }

        public void AddEntryToCurrentWorspace()
        {
            CurrentWorkspace.AddApplicationEntry();

            SaveWorkspaces();

            OnCurrentApplicationListModified(null);
        }

        public void RemoveEntryFromCurrentWorkspace(int entryID)
        {
            CurrentWorkspace.RemoveApplicationEntry(entryID);

            SaveWorkspaces();

            OnCurrentApplicationListModified(null);
        }

        public void LaunchAllAppsOfCurrentWorkspace()
        {
            foreach (ApplicationEntry entry in CurrentWorkspace.ApplicationEntries)
            {
                entry.StartApplication();
            }
        }

        private void SyncWorkspaceIDCounter()
        {
            WorkspaceIDCounter = 0;
            foreach(Workspace w in Workspaces)
            {
                if (w.ID >= WorkspaceIDCounter)
                {
                    WorkspaceIDCounter = w.ID + 1;
                }
            }
        }

        private void ImportWorkspaces()
        {
            Workspaces = sm.ImportWorkspacesFromJson();

            if (Workspaces.Count > 0)
            {
                SyncWorkspaceIDCounter();
            }
            else
            {
                AddWorkspaceWithoutEvent();
            }
        }

        private void LoadLastUsedWorkspaceID()
        {
            if (Workspaces.Where(w => w.ID == Properties.Settings.Default.LastUsedWorkspaceID) != null)
            {
                CurrentWorkspaceID = Properties.Settings.Default.LastUsedWorkspaceID;
            }
            else
            {
                CurrentWorkspaceID = 0;
            }
        }

        private void SaveLastUsedWorkspaceID(int lastUsedWorkspaceID)
        {
            Properties.Settings.Default.LastUsedWorkspaceID = lastUsedWorkspaceID;
            Properties.Settings.Default.Save();
        }

        private void SubscribeToCurrentWorkspaceEvents()
        {
            CurrentWorkspace.PropertyChanged += new PropertyChangedEventHandler(cw_PropertyChanged);
            CurrentWorkspace.EntryModified += new EventHandler(cw_EntryModified);
        }

        private void cw_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Name")
            {
                SaveWorkspaces();

                OnWorkspaceListModified(null);
            }
        }

        private void cw_EntryModified(object sender, EventArgs e)
        {
            SaveWorkspaces();
        }

        private void SaveWorkspaces()
        {
            sm.ExportWorkspacesToJSON(Workspaces);
        }

        protected virtual void OnCurrentWorkspaceChanged(EventArgs e)
        {
            EventHandler handler = CurrentWorkspaceChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnCurrentApplicationListModified(EventArgs e)
        {
            EventHandler handler = CurrentApplicationListModified;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnWorkspaceListModified(EventArgs e)
        {
            EventHandler handler = WorkspaceListModified;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
