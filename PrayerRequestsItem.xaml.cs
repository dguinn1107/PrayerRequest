using System;
using Microsoft.Maui.Controls;

namespace PrayerRequest
{
    public partial class PrayerRequestItem : ContentView
    {
        private int _prayerCount = 0;

        public PrayerRequestItem()
        {
            InitializeComponent();
        }

        private void PrayButton_Clicked(object sender, EventArgs e)
        {
            _prayerCount++;
            CountLabel.Text = _prayerCount.ToString();
        }
    }
}
