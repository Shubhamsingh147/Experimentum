using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.ViewModels;
using PhoneApp1.Model;
using System.Collections.ObjectModel;
namespace PhoneApp1
{
    public partial class Page1 : PhoneApplicationPage
    {
        private ViewModel viewModel = new ViewModel();
        public Page1()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            
            var list = NavigationService.GetLastNavigationData();
            if (list != null)
            {
                viewModel.Collection = (ObservableCollection<Models>)list;
            }
            //viewModel.Collection.Add(new Models(3, 5));
            chart.DataContext = viewModel;
        }
    }
    
}