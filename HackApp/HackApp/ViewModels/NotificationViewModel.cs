using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HackApp.ViewModels
{
   public class NotificationViewModel
    {
        private Notification _oldNotification;
        public ObservableCollection<Notification> Notifications { get; set; }

        public NotificationViewModel()
        {
            Notifications = new ObservableCollection<Notification>
            {
                new Notification
                {
                    Title= "Kindergarten \"Regenbogen\"",
                    Preview="Aufgrund zu hoher Belastung von Eichenprozessionsspinner, bleibt der Kindergarten in der bis zum 2.10.19 geschlossen.",
                    Date="22.09.19",
                    IsVisible =false

                },
                new Notification
                {
                    Title= "Münster Hauptbahnhof",
                    Preview="Der Münster Hauptbahnhof ist wieder EPS frei.",
                    Date="26.09.19",
                    IsVisible =false
                },
                new Notification
                {
                    Title= "Aral(Wolbecker Str. 140A)",
                    Preview="Das Auftanken funktioniert wieder wie gewohnt.",
                    Date="16.09.19",
                    IsVisible =false
                },
                
            };
        }

        internal void HideOrShow(Notification notification)
        {
            if (_oldNotification == notification)
            {
                //click twice on the same item will hide it
                notification.IsVisible = !notification.IsVisible;
                UpdateNotifications(notification);
            }
            else
            {
                if (_oldNotification != null)
                {
                    //hide previous selected item
                    _oldNotification.IsVisible = false;
                    UpdateNotifications(_oldNotification);
                }
                //show selected item
                notification.IsVisible = true;
                UpdateNotifications(notification);
            }
            _oldNotification = notification;
        }

        private void UpdateNotifications(Notification notification)
        {
            var index = Notifications.IndexOf(notification);
            Notifications.Remove(notification);
            Notifications.Insert(index,notification);
        }
        public void AddNewNotification(Notification notification)
        {
            Notifications.Add(notification);
        }
    }
}
