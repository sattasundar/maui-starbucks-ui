namespace MauiStarbucks.Views.Pages;

public partial class HomePage : CustomTabBar
{
	public HomePage()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync($"detail");
	}

	private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	{
	}
}