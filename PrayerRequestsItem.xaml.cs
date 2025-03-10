using System;
using Microsoft.Maui.Controls;

namespace PrayerRequest
{
    public partial class PrayerRequestItem : ContentView
    {
        public PrayerRequestItem()
        {
            InitializeComponent();
        }

        private void PrayButton_Clicked(object sender, EventArgs e)
        {
            if (BindingContext is PrayerRequestData data)
            {
                data.PrayerCount++;
            }
        }
    }
}
