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
                    Title= "Bafall 1",
                    IsVisible =false

                },
                new Notification
                {
                    Title= "Bafall 2"
                },
                new Notification
                {
                    Title= "Bafall 3"
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
    }
}
