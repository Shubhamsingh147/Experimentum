using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneApp1.Model;

namespace PhoneApp1.ViewModels
{
    public class ViewModel
    {
        public ObservableCollection<Models> Collection { get; set; }
        public ViewModel()
        {
            Collection = new ObservableCollection<Models>();
            //GenerateDatas();
        }
        private void GenerateDatas()
        {
            this.Collection.Add(new Models(0, 1));
            this.Collection.Add(new Models(1, 2));
            this.Collection.Add(new Models(2, 3));
            this.Collection.Add(new Models(3, 4));
        }
    }
}
