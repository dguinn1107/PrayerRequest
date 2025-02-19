

namespace PrayerRequest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnImageButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Prayer Request", "You clicked the prayer image!", "OK");
        }

        private void OnDateChanged(object sender, DateChangedEventArgs e)
        {
            var selectedDate = e.NewDate;
            Console.WriteLine($"Selected date: {selectedDate.ToShortDateString()}");
        }


        private async void OnSubmitClicked(object sender, EventArgs e)
        {
            var prayerRequest = PrayerRequestEntry.Text;
            
            Preferences.Set("SelectedPickerIndex", PickerControl.SelectedIndex);
            Preferences.Set("SelectedPickerValue", PickerControl.SelectedItem?.ToString());

            
            Preferences.Set("SliderValue", SliderControl.Value);

         
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

           
            if (Preferences.ContainsKey("SelectedPickerIndex"))
            {
                int savedIndex = Preferences.Get("SelectedPickerIndex", 0);
                if (savedIndex >= 0 && savedIndex < PickerControl.Items.Count)
                {
                    PickerControl.SelectedIndex = savedIndex;
                }
            }

           
            if (Preferences.ContainsKey("SliderValue"))
            {
                SliderControl.Value = Preferences.Get("SliderValue", 1); 
            }
        }
    }
}

