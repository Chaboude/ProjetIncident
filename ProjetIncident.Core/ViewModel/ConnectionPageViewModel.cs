using System;
using System.Windows.Input;
using ProjetIncident.Core.Views;
using Xamarin.Forms;

namespace ProjetIncident.Core.ViewModel
{
    public class ConnectionPageViewModel : BaseViewModel
    {
        public ICommand Connect { get; set; }

        public string Username
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        public string Password
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        public ConnectionPageViewModel(){
            Connect = new Command(async()=>{
                if (!(Username == null || Password == null))
                {
                    Application.Current.MainPage = new MasterDetailPageNavigation();
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Connexion impossible", "Tous les champs n'ont pas été resneignés", "OK");
                }
            });
        }
    }
}

