using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace PrayerRequest
{
    public class RequestsViewModel : BindableObject
    {
        public ObservableCollection<PrayerRequestData> PrayerRequests { get; } = new ObservableCollection<PrayerRequestData>();

        public ICommand AddRequestCommand { get; }

        public RequestsViewModel()
        {
            AddRequestCommand = new Command(AddRequest);

            PrayerRequests.Add(new PrayerRequestData
            {
                RequestText = "Pray for me!",
                PrayerCount = 0
            });
        }

        private void AddRequest()
        {
            PrayerRequests.Add(new PrayerRequestData
            {
                RequestText = "New prayer request",
                PrayerCount = 0
            });
        }
    }
}
