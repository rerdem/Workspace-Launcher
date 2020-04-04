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
    public class ApplicationEntry: INotifyPropertyChanged
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
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
                OnPropertyChanged();
            }
        }
        public string Parameters
        {
            get
            {
                return parameters;
            }
            set
            {
                parameters = value;
                OnPropertyChanged();
            }
        }

        private int id;
        private string name;
        private string path;
        private string parameters;

        public ApplicationEntry(int id)
        {
            ID = id;
            Name = "";
            Path = "";
            Parameters = "";
        }

        [JsonConstructor]
        public ApplicationEntry(int id, string name, string path, string parameters)
        {
            ID = id;
            Name = name;
            Path = path;
            Parameters = parameters;
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
