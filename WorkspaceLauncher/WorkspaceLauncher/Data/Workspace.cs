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
        public event EventHandler EntryModified;

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
        public Workspace(int id, string name, List<ApplicationEntry> applicationEntries)
        {
            ID = id;
            Name = name;
            ApplicationEntries = applicationEntries;
            
            EntryIDCounter = 0;
            SyncEntryIDCounter();
            SubscribeToAllEntryPropertyChangedEvents();
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
            ApplicationEntry entry = new ApplicationEntry(EntryIDCounter);
            entry.PropertyChanged += new PropertyChangedEventHandler(ae_PropertyChanged);
            ApplicationEntries.Add(entry);
            EntryIDCounter++;
        }

        public void RemoveApplicationEntry(int entryID)
        {
            int indexToDelete = ApplicationEntries.FindIndex(app => app.ID == entryID);
            ApplicationEntries.ElementAt(indexToDelete).PropertyChanged -= new PropertyChangedEventHandler(ae_PropertyChanged);
            ApplicationEntries.RemoveAt(indexToDelete);

        }

        private void SubscribeToAllEntryPropertyChangedEvents()
        {
            foreach (ApplicationEntry entry in ApplicationEntries)
            {
                entry.PropertyChanged += new PropertyChangedEventHandler(ae_PropertyChanged);
            }
        }

        private void ae_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnEntryModified(null);
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        protected virtual void OnEntryModified(EventArgs e)
        {
            EventHandler handler = EntryModified;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
