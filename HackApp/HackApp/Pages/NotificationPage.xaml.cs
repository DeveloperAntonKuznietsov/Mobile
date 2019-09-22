using HackApp.ViewModels;
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
    public partial class NotificationPage : ContentPage
    {
        private int _flagNew;
        public NotificationPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as NotificationViewModel;

            var notification = e.Item as Notification;
            vm.HideOrShow(notification);
        }

        private void BtnNotification_Clicked(object sender, EventArgs e)
        {
            btnNotification.BackgroundColor = Color.FromHex("#20B2AA");
            btnNotification.TextColor = Color.White;
            btnUpdates.BackgroundColor = Color.White; ;
            btnUpdates.TextColor = Color.FromHex("#C26A00");

            listNotifications.IsVisible = true;
            listOfUpdates.IsVisible = false;

        }

        private void BtnUpdates_Clicked(object sender, EventArgs e)
        {
            btnUpdates.BackgroundColor = Color.FromHex("#20B2AA");
            btnUpdates.TextColor = Color.White;
            btnNotification.BackgroundColor = Color.White; ;
            btnNotification.TextColor = Color.FromHex("#C26A00");

            listNotifications.IsVisible = false;
            listOfUpdates.IsVisible = true;
           

            if (_flagNew == 0)
            {
                var vm = BindingContext as NotificationViewModel;
                var newNotification = new Notification
            {
                Title = "CINEPLEX Münster",
                Preview = "30.09 ist der Bürgersteig bis 12.00 Uhr geschlossen.",
                Date = "26.09.2019",
                IsVisible = false
            };
            vm.AddNewNotification(newNotification);
            }
            _flagNew++;
        }
    }
}