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
                var pinCineplex = new Pin()
                {
                    Position = new Position(51.9519062, 7.6321126),
                    Label = "CINEPLEX Münster",
                    Address= "30.09 ist der Bürgersteig bis 12.00 Uhr geschlossen.",
                };
                var pinKindergarten = new Pin()
                {
                    Position = new Position(51.97004, 7.6333313),
                    Label = "Kindergarten \"Regenbogen\"",
                    Address = "Belastung von Eichenprozessionsspinner.",
                };
                var pinBahnhof = new Pin()
                {
                    Position = new Position(51.9625937, 7.5202854),
                    Label = "Münster Hauptbahnhof",
                    Address = "Der Hauptbahnhof ist wieder EPS frei.",
                };
                var pinAral = new Pin()
                {
                    Position = new Position(51.9540987, 7.6399258),
                    Label = "Aral",
                    Address = "Funktioniert wieder .",
                };
                MyMap.Pins.Add(pinCineplex);
                MyMap.Pins.Add(pinKindergarten);
                MyMap.Pins.Add(pinBahnhof);
                MyMap.Pins.Add(pinAral);
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

        private void BtnNotification_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NotificationPage());
        }
    }
}

