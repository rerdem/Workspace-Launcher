using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkspaceLauncher.Data;

namespace WorkspaceLauncher.Management
{
    public class WorkspaceManager
    {
        public event EventHandler CurrentWorkspaceChanged;

        public List<Workspace> Workspaces { get; set; }
        
        private SerializationManager sm;
        private int WorkspaceIDCounter;

        public WorkspaceManager()
        {
            Workspaces = new List<Workspace>();
            
            sm = new SerializationManager();

            WorkspaceIDCounter = 0;
            
            ImportWorkspaces();

            SetupTestingEnvironment();
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
                //TO DO
                //SetCurrentWorkspace(Properties.Settings.Default.LastUsedWorkspaceID);
                //!!!!!! Validate exe paths or throw warning and deactivate launch buttons!!!!!!!
            }
            else
            {
                AddWorkspace();
            }

        }

        //private void SaveLastUsedWorkspaceID()
        //{
        //    Properties.Settings.Default.LastUsedWorkspaceID = 0;
        //    Properties.Settings.Default.Save();
        //}

        protected virtual void OnCurrentWorkspaceChanged(EventArgs e)
        {
            EventHandler handler = CurrentWorkspaceChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
