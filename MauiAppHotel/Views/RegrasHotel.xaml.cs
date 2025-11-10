namespace MauiAppHotel.Views;

public partial class RegrasHotel : ContentPage
{
    public RegrasHotel()
    {
        InitializeComponent(); 
    }

    private async void OnVoltarClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
