using System;
using System.Collections.ObjectModel;
using ProjetIncident.Core.Model;
using ProjetIncident.Core.Views;
using Xamarin.Forms;

namespace ProjetIncident.Core.ViewModel
{
    public class NavigationDrawerViewModel : BaseViewModel
    {
        public NavigationDrawerViewModel()
        {
            menuList = new ObservableCollection<MasterPageItem>();
            menuList.Add(new MasterPageItem() { Title = "Liste des Incidents", IconSource = "liste.png", TargetType = typeof(HomePage) });
            menuList.Add(new MasterPageItem() { Title = "Se deconnecter", IconSource = "logout.png", TargetType = typeof(ConnectionPage) });

            ProfileName = "Thomas";
            ProfilePicture = "davidgoodenough.png";
        }

        public string ProfileName
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        public string ProfilePicture
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        public ObservableCollection<MasterPageItem> menuList
        {
            get => GetProperty<ObservableCollection<MasterPageItem>>();
            set => SetProperty(value);
        }
    }
}
