using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ProjetIncident.Core.Model;
using ProjetIncident.Core.ViewModel;
using ProjetIncident.Core.Views;
using Xamarin.Forms;

namespace ProjetIncident.Core.ViewModel
{
    public class AddIncidentViewModel : BaseViewModel
    {
        public ICommand AjouterIncident { get; set; }

        public ObservableCollection<Category> CategoriesIncident { 
            get => GetProperty<ObservableCollection<Category>>(); 
            set => SetProperty(value); 
        }

        public string Titre
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        public Category CategoryIncident
        {
            get => GetProperty<Category>();
            set => SetProperty(value);
        }

        public AddIncidentViewModel()
        {
            CategoriesIncident = new ObservableCollection<Category>();
            CategoriesIncident.Add(new Category("Dégradation"));
            CategoriesIncident.Add(new Category("Accident"));
            CategoriesIncident.Add(new Category("Incendie"));
            CategoriesIncident.Add(new Category("Innondation"));

            AjouterIncident = new Command(async () =>
            {
                if (!(Titre == null || CategoryIncident == null))
                {
                    Application.Current.MainPage = new MasterDetailPageNavigation();
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Ajout d'un incident impossible", "Tous les champs n'ont pas été renseignés", "OK");
                }
            });
        }
    }
}
