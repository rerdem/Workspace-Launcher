using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkspaceLauncher.Data;

namespace WorkspaceLauncher.Management
{
    public class WorkspaceManager
    {
        public event EventHandler CurrentWorkspaceChanged;
        public event EventHandler CurrentApplicationListModified;

        public List<Workspace> Workspaces { get; set; }
        public int CurrentWorkspaceID { get { return currentWorkspaceID; }
        set
            {
                currentWorkspaceID = value;
                SaveLastUsedWorkspaceID(currentWorkspaceID);

                OnCurrentWorkspaceChanged(null);
            }
        }
        public Workspace CurrentWorkspace { get { return Workspaces.Where(w => w.ID == CurrentWorkspaceID).First(); } }

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

            //SetupTestingEnvironment();
        }

        private void SetupTestingEnvironment()
        {
            AddWorkspace("test1");
            AddWorkspace("test2");
            AddWorkspace("test3");

            foreach(Workspace w in Workspaces)
            {
                w.AddApplicationEntry();
                w.AddApplicationEntry();
                w.AddApplicationEntry();
            }
        }

        public void AddWorkspace()
        {
            Workspaces.Add(new Workspace(WorkspaceIDCounter, $"Workspace_{DateTime.Now.ToString("yyyy-MM-dd_HHmmss")}"));
            WorkspaceIDCounter++;
        }
        public void AddWorkspace(string name)
        {
            Workspaces.Add(new Workspace(WorkspaceIDCounter, name));
            WorkspaceIDCounter++;
        }

        public void RemoveEntryFromCurrentWorkspace(int entryID)
        {
            CurrentWorkspace.RemoveApplicationEntry(entryID);

            OnCurrentApplicationListModified(null);
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
            //Workspaces = sm.ImportWorkspacesFromJson();
            SetupTestingEnvironment();

            if (Workspaces.Count > 0)
            {
                SyncWorkspaceIDCounter();
                //TO DO
                //!!!!!! Validate exe paths or throw warning and deactivate launch buttons!!!!!!!
            }
            else
            {
                AddWorkspace();
            }
        }

        private void LoadLastUsedWorkspaceID()
        {
            if (Workspaces.Where(w => w.ID == Properties.Settings.Default.LastUsedWorkspaceID).First() != null)
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
    }
}
