using System;
using System.Collections.Generic;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace ProjetIncident.Core.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

		public void OnButtonClicked(object sender, EventArgs args)
		{
			Button button = (Button)sender;
            App.Current.MainPage = NavigationService.GetCurrent().RootPage;
		}
    }
}
