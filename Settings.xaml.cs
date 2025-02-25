using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage; 

namespace PrayerRequest
{
    public partial class Settings : ContentPage
    {
        const string DefaultUrgencyKey = "DefaultUrgency";
        const string DefaultExpirationKey = "DefaultExpiration";

        public Settings()
        {
            InitializeComponent();

            var savedUrgency = Preferences.Get(DefaultUrgencyKey, "Medium");
            var savedExpiration = Preferences.Get(DefaultExpirationKey, 12.0); 

            for (int i = 0; i < UrgencyPicker.Items.Count; i++)
            {
                if (UrgencyPicker.Items[i] == savedUrgency)
                {
                    UrgencyPicker.SelectedIndex = i;
                    break;
                }
            }

            ExpirationSlider.Value = savedExpiration;
            ExpirationValueLabel.Text = $"{savedExpiration:F1} hours";
        }

        private void UrgencyPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UrgencyPicker.SelectedIndex != -1)
            {
                string selectedUrgency = UrgencyPicker.Items[UrgencyPicker.SelectedIndex];
                Preferences.Set(DefaultUrgencyKey, selectedUrgency);
            }
        }

        private void ExpirationSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double newExpiration = e.NewValue;
            Preferences.Set(DefaultExpirationKey, newExpiration);
            ExpirationValueLabel.Text = $"{newExpiration:F1} hours";
        }
    }
}
