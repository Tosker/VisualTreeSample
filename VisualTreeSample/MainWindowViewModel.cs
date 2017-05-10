using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace VisualTreeSample
{
    public class MainWindowViewModel : ObservableObject
    {
        public ListViewViewModel ListView { get; set; }
        public ICommand RemoveNameCommand { get; set; }

        public MainWindowViewModel()
        {
            ListView = new ListViewViewModel();
            RemoveNameCommand = new RelayCommand<string>(RemoveName);
        }

        private void RemoveName(string obj)
        {
            ListView.Names.Remove(obj);
        }
    }
}
