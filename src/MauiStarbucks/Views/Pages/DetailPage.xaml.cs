namespace MauiStarbucks.Views.Pages;

public partial class DetailPage : ContentPage
{
	public DetailPage()
	{
		InitializeComponent();
		this.BindingContext = AppLocator.DetailViewModel;
	}
	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
	}
}