namespace MauiStarbucks;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Shell.SetTabBarIsVisible(this, false);
        Routing.RegisterRoute("detail", typeof(DetailPage));
    }
}
