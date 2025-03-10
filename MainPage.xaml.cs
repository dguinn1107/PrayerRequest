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
                int savedIndex = 0;
                try
                {
                    savedIndex = Preferences.Get("SelectedPickerIndex", 0);
                }
                catch (InvalidCastException)
                {
                    var savedIndexStr = Preferences.Get("SelectedPickerIndex", "0");
                    int.TryParse(savedIndexStr, out savedIndex);
                }

                if (savedIndex >= 0 && savedIndex < PickerControl.Items.Count)
                {
                    PickerControl.SelectedIndex = savedIndex;
                }
            }

            if (Preferences.ContainsKey("SliderValue"))
            {
                double sliderValue = 1;
                try
                {
                    sliderValue = Preferences.Get("SliderValue", 1.0);
                }
                catch (InvalidCastException)
                {
                    var sliderValueStr = Preferences.Get("SliderValue", "1");
                    double.TryParse(sliderValueStr, out sliderValue);
                }

                SliderControl.Value = sliderValue;
            }
        }
    }
}

