namespace MauiStarbucks;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        App.Current.UserAppTheme = AppTheme.Light;
        AppLocator.Initialize();
		MainPage = new AppShell();
	}
}
