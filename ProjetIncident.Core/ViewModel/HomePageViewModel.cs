using System;
using System.Collections.ObjectModel;
using ProjetIncident.Core.DataAccess;
using ProjetIncident.Core.Model;

namespace ProjetIncident.Core.ViewModel
{
    public class HomePageViewModel : BaseViewModel
    {
        public ObservableCollection<Incident> CategoryIncident {
            get => GetProperty<ObservableCollection<Incident>>();
            set => SetProperty(value); 
        }

        public HomePageViewModel()
        {
            CategoryIncident = new ObservableCollection<Incident>();
            CategoryIncident.Add(new Incident("test incident"));
        }
    }
}
