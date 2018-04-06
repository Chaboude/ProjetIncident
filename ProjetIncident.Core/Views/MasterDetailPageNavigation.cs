using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetIncident.Core.Model;
using ProjetIncident.Core.ViewModel;
using Xamarin.Forms;

namespace ProjetIncident.Core.Views
{
    public partial class MasterDetailPageNavigation : MasterDetailPage
    {
        public MasterDetailPageNavigation()
        {
            this.BindingContext = new NavigationDrawerViewModel();
            InitializeComponent();
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
        }

        // Event for Menu Item selection, here we are going to handle navigation based
        // on user selection in menu ListView
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;

            if(page == typeof(ConnectionPage)){
                Application.Current.MainPage = new ConnectionPage();
            }
            else{
                Application.Current.MainPage = new NavigationPage((Page)Activator.CreateInstance(page));   
            }
            IsPresented = false;
        }
    }
}

