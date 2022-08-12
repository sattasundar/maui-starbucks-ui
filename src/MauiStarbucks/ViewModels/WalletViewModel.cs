namespace MauiStarbucks.ViewModels
{
    [INotifyPropertyChanged]
    public partial class WalletViewModel: BaseViewModel
    {
        public override Task Initialize()
        {
            return Task.CompletedTask;
        }

        public override Task Stop()
        {
            return Task.CompletedTask;
        }
    }
}
