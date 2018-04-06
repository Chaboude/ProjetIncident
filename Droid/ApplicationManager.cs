using System;
using Android.App;
using ProjetIncident.Core;
using ProjetIncident.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(ProjetIncident.Droid.ApplicationManager))]

namespace ProjetIncident.Droid
{
    public class ApplicationManager : IApplicationManager
    {
        // Méthode permettant de fermer l’application
        public void CloseApplication()
        {
            var activity = (Activity)Xamarin.Forms.Forms.Context;
            activity?.FinishAffinity();
        }
    }
}
