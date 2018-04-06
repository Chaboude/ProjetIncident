using System;
using System.Collections.Generic;
using Plugin.Media;
using ProjetIncident.Core.DataAccess;
using ProjetIncident.Core.Model;
using ProjetIncident.Core.ViewModel;
using Xamarin.Forms;

namespace ProjetIncident.Core.Views
{
    public partial class Add_Formulaire : ContentPage
    {
        public Add_Formulaire()
        {
            this.BindingContext = new AddIncidentViewModel();
            InitializeComponent();
            CameraButton.Clicked += CameraButton_Clicked;
        }

        private async void CameraButton_Clicked(object sender, EventArgs e)
        {

            await Plugin.Media.CrossMedia.Current.Initialize();

            if (!Plugin.Media.CrossMedia.Current.IsCameraAvailable)
            {
                await Application.Current.MainPage.DisplayAlert("Prise de photo", "Impossible de prendre une photo : votre appareil ne possède pas de caméra.", "OK");
                return;
            }

            if (!Plugin.Media.CrossMedia.Current.IsTakePhotoSupported)
            {
                await Application.Current.MainPage.DisplayAlert("Prise de photo", "Impossible de prendre une photo : votre appareil ne propose pas la prise de photos.", "OK");
                return;
            }

            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(
                        new Plugin.Media.Abstractions.StoreCameraMediaOptions()
                        {
                            DefaultCamera = Plugin.Media.Abstractions.CameraDevice.Rear,
                            RotateImage = true,
                            CustomPhotoSize = 5,
                            AllowCropping = true,
                            CompressionQuality = 20
                        });

            PhotoImage.Source = ImageSource.FromStream( () => { return photo.GetStream(); } );
        }
    }
}
