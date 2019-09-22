using Plugin.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HackApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FotoPage : ContentPage
    {
        public FotoPage()
        {
            InitializeComponent();
        }

        private async void TakePicture_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
              await  DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Sample",
                Name = "test.jpg"
            });

            if (file == null)
                return;
            Image1.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                return stream;
            });
            TakePicture.IsVisible = false;
            Image1.IsVisible = true;
        }

        private void UploadFoto_Clicked(object sender, EventArgs e)
        {
            
            
        }

        private void BtnPrivate_Clicked(object sender, EventArgs e)
        {
            //TextColor = "#C26A00"
            //       BackgroundColor = "White"
            //       BorderColor = "#20B2AA"
            btnPrivate.TextColor = Color.White;
            btnPrivate.BackgroundColor = Color.FromHex("#20B2AA");
            btnWald.TextColor= Color.FromHex("#C26A00");
            btnWald.BackgroundColor = Color.White;
            btnSchule.TextColor = Color.FromHex("#C26A00");
            btnSchule.BackgroundColor = Color.White;
            btnBahnhof.TextColor = Color.FromHex("#C26A00");
            btnBahnhof.BackgroundColor = Color.White;
            btnPark.TextColor = Color.FromHex("#C26A00");
            btnPark.BackgroundColor = Color.White;
        }

        private void BtnWald_Clicked(object sender, EventArgs e)
        {
            btnWald.TextColor = Color.White;
            btnWald.BackgroundColor = Color.FromHex("#20B2AA");
            btnPrivate.TextColor = Color.FromHex("#C26A00");
            btnPrivate.BackgroundColor = Color.White;
            btnSchule.TextColor = Color.FromHex("#C26A00");
            btnSchule.BackgroundColor = Color.White;
            btnBahnhof.TextColor = Color.FromHex("#C26A00");
            btnBahnhof.BackgroundColor = Color.White;
            btnPark.TextColor = Color.FromHex("#C26A00");
            btnPark.BackgroundColor = Color.White;
        }

        private void BtnSchule_Clicked(object sender, EventArgs e)
        {
            btnSchule.TextColor = Color.White;
            btnSchule.BackgroundColor = Color.FromHex("#20B2AA");
            btnWald.TextColor = Color.FromHex("#C26A00");
            btnWald.BackgroundColor = Color.White;
            btnPrivate.TextColor = Color.FromHex("#C26A00");
            btnPrivate.BackgroundColor = Color.White;
            btnBahnhof.TextColor = Color.FromHex("#C26A00");
            btnBahnhof.BackgroundColor = Color.White;
            btnPark.TextColor = Color.FromHex("#C26A00");
            btnPark.BackgroundColor = Color.White;
        }

        private void BtnBahnhof_Clicked(object sender, EventArgs e)
        {
            btnBahnhof.TextColor = Color.White;
            btnBahnhof.BackgroundColor = Color.FromHex("#20B2AA");
            btnWald.TextColor = Color.FromHex("#C26A00");
            btnWald.BackgroundColor = Color.White;
            btnSchule.TextColor = Color.FromHex("#C26A00");
            btnSchule.BackgroundColor = Color.White;
            btnPrivate.TextColor = Color.FromHex("#C26A00");
            btnPrivate.BackgroundColor = Color.White;
            btnPark.TextColor = Color.FromHex("#C26A00");
            btnPark.BackgroundColor = Color.White;
        }

        private void BtnPark_Clicked(object sender, EventArgs e)
        {
            btnPark.TextColor = Color.White;
            btnPark.BackgroundColor = Color.FromHex("#20B2AA");
            btnWald.TextColor = Color.FromHex("#C26A00");
            btnWald.BackgroundColor = Color.White;
            btnSchule.TextColor = Color.FromHex("#C26A00");
            btnSchule.BackgroundColor = Color.White;
            btnBahnhof.TextColor = Color.FromHex("#C26A00");
            btnBahnhof.BackgroundColor = Color.White;
            btnPrivate.TextColor = Color.FromHex("#C26A00");
            btnPrivate.BackgroundColor = Color.White;
        }

        private void BtnMelden_Clicked(object sender, EventArgs e)
        {
            TakePicture.IsVisible = true;
            Image1.IsVisible = false;
            DisplayAlert("Nachricht ", "Ihre Nachricht wurde versendet und wird bearbeitet.", "OK");
        }
    }
}