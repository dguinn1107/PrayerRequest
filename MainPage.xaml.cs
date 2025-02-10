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
        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            int sliderValue = (int)Math.Round(e.NewValue);
            SliderControl.Value = sliderValue; 
            SliderValueLabel.Text = sliderValue.ToString() + " days"; 
        }


        private void OnSubmitClicked(object sender, EventArgs e)
        {
            var prayerRequest = PrayerRequestEntry.Text;

        }
    }
}

