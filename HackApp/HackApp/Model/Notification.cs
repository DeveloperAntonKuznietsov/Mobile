using System;
using System.Collections.Generic;
using System.Text;

namespace HackApp.ViewModels
{
   public class Notification
    {
        public string Title { get; set; }
        public string Preview { get; set; }
        public string Date { get; set; }

        public bool IsVisible { get; set; }
    }
}
