using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WorkspaceLauncher.Data
{
    public class Workspace : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int ID
        {
            get
            {
                return id;
            }
            private set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public List<ApplicationEntry> ApplicationEntries { get; }
        
        private int EntryIDCounter;

        private int id;
        private string name;

        public Workspace(int id, string name)
        {
            ID = id;
            Name = name;
            ApplicationEntries = new List<ApplicationEntry>();

            EntryIDCounter = 0;
        }

        [JsonConstructor]
        public Workspace(int id, string name, List<ApplicationEntry> entries)
        {
            ID = id;
            Name = name;
            ApplicationEntries = entries;
            
            EntryIDCounter = 0;
            SyncEntryIDCounter();
        }

        private void SyncEntryIDCounter()
        {
            foreach (ApplicationEntry entry in ApplicationEntries)
            {
                if (entry.ID >= EntryIDCounter)
                {
                    EntryIDCounter = entry.ID + 1;
                }
            }
        }

        public void AddApplicationEntry()
        {
            ApplicationEntries.Add(new ApplicationEntry(EntryIDCounter));
            EntryIDCounter++;
        }

        //public void RemoveApplicationEntry(int entryID)
        //{
        //    ApplicationEntries.RemoveAt(ApplicationEntries.FindIndex(app => app.ID == entryID));

        //}

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
