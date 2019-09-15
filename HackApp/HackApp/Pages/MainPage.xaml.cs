using HackApp.Pages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace HackApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public  MainPage()
        {
            InitializeComponent();

            UpdateMapAsync();
        }


        List<Place> placesList = new List<Place>();

        private void UpdateMapAsync()
        {
            try
            {
                var pin = new Pin()
                {
                    Position = new Position(51.9502139, 7.4840153),
                    Label = "Some Pin!",
                    Address="Home",
                };
                MyMap.Pins.Add(pin);
                MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(51.9502139, 7.4840153), Distance.FromKilometers(100)));
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }


        }

        private void BtnMenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuPage());
        }

        private void AddNewIncident_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FotoPage());
        }
    }
}

