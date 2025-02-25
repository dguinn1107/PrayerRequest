using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;

namespace PrayerRequest;

public partial class Requests : ContentPage
{
	public Requests()
	{
		InitializeComponent();
	}

	private void AddRequests(object sender, EventArgs e)
	{
        var item = new PrayerRequestItem();
        verticalStackLayout.Children.Add(item);
    }

}
