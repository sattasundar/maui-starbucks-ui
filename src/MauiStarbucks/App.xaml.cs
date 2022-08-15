namespace MauiStarbucks;

public partial class App : Application
{
	public App()
	{
		AppLocator.DisplayHeight = (DeviceDisplay.Current.MainDisplayInfo.Height / DeviceDisplay.Current.MainDisplayInfo.Density) - 125;
        InitializeComponent();
        App.Current.UserAppTheme = AppTheme.Light;
        AppLocator.Initialize();
		MainPage = new AppShell();
	}
}
