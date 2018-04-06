using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Xamarin.Forms;

namespace ProjetIncident.Core.Views
{
    public partial class ConnectionPage : ContentPage
    {
        public ConnectionPage()
        {
            this.BindingContext = new ViewModel.ConnectionPageViewModel();
            InitializeComponent();
        }

        public async Task<Dictionary<Permission, PermissionStatus>> AskForPermissions()
        {
            Permission[] perms = { Permission.Storage, Permission.Camera };
            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Storage);
                if (status != PermissionStatus.Granted)
                {
                    var results = CrossPermissions.Current.RequestPermissionsAsync(perms);
                    return await results;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
