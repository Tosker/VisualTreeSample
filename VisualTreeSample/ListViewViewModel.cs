using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace VisualTreeSample
{
    public class ListViewViewModel
    {
        public ObservableCollection<string> Names { get; set; }

        public ListViewViewModel()
        {
            Names = new ObservableCollection<string>()
            {
                "Joe",
                "Jane",
                "John",
                "Jessica",
                "Matt"
            };
        }
    }
}
