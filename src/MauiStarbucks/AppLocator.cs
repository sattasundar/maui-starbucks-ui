namespace MauiStarbucks
{
    public static class AppLocator
    {
        public static HomeViewModel HomeViewModel => Locator.Current.GetService<HomeViewModel>();
        public static WalletViewModel WalletViewModel => Locator.Current.GetService<WalletViewModel>();
        public static FavouriteViewModel FavouriteViewModel => Locator.Current.GetService<FavouriteViewModel>();
        public static NotificationViewModel NotificationViewModel => Locator.Current.GetService<NotificationViewModel>();
        public static DetailViewModel DetailViewModel => Locator.Current.GetService<DetailViewModel>();
        public static double DisplayHeight { get; set; }

        public static void Initialize()
        {
            Locator.CurrentMutable.Register(()=>new HomeViewModel());
            Locator.CurrentMutable.Register(()=>new WalletViewModel());
            Locator.CurrentMutable.Register(()=>new FavouriteViewModel());
            Locator.CurrentMutable.Register(()=>new NotificationViewModel());
            Locator.CurrentMutable.Register(()=>new DetailViewModel());
            DisplayHeight = (DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density)-130;
        }
    }
}
