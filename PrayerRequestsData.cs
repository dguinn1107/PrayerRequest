using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace PrayerRequest
{
    
    public class PrayerRequestData : BindableObject
    {
        private string _requestText;
        public string RequestText
        {
            get => _requestText;
            set { _requestText = value; OnPropertyChanged(); }
        }

        private int _prayerCount;
        public int PrayerCount
        {
            get => _prayerCount;
            set { _prayerCount = value; OnPropertyChanged(); }
        }
    }
}
