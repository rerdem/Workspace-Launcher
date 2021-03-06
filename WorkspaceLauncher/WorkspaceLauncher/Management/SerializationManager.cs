﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkspaceLauncher.Data;

namespace WorkspaceLauncher.Management
{
    public class SerializationManager
    {
        public event EventHandler WorkspacesSaved;

        private readonly string FolderPath;
        private readonly string WorkspacesFilePath;

        public SerializationManager()
        {
            FolderPath = $"{Directory.GetCurrentDirectory()}{Path.DirectorySeparatorChar}";
            WorkspacesFilePath = $"{FolderPath}workspaces{Path.DirectorySeparatorChar}workspaces.json";
            Directory.CreateDirectory($"{FolderPath}workspaces");
        }

        public void ExportWorkspacesToJSON(List<Workspace> workspaceList)
        {
            int indexOfLastBackslash = WorkspacesFilePath.LastIndexOf("\\");
            FileInfo file = new FileInfo(WorkspacesFilePath.Substring(0, indexOfLastBackslash));
            file.Directory.Create();
            File.WriteAllText(WorkspacesFilePath, JsonConvert.SerializeObject(workspaceList, Formatting.Indented));
            
            OnWorkspacesSaved(null);
        }

        public List<Workspace> ImportWorkspacesFromJson()
        {
            List<Workspace> workspaceList = new List<Workspace>();

            if (File.Exists(WorkspacesFilePath))
            {
                workspaceList = JsonConvert.DeserializeObject<List<Workspace>>(File.ReadAllText(WorkspacesFilePath));
            }

            return workspaceList;
        }

        protected virtual void OnWorkspacesSaved(EventArgs e)
        {
            EventHandler handler = WorkspacesSaved;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
