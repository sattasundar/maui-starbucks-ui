namespace MauiStarbucks.ViewModels
{
    [INotifyPropertyChanged]
    [QueryProperty(nameof(SelectedProduct), nameof(SelectedProduct))]
    public partial class DetailViewModel : BaseViewModel
    {
        [ObservableProperty]
        Product _selectedProduct;

        [ObservableProperty]
        List<ProductSize> _productSizes;
        partial void OnSelectedProductChanged(Product value)
        {
            Debug.WriteLine(value);
        }
        public DetailViewModel()
        {

        }
        public override Task Initialize()
        {
            return Task.CompletedTask;
        }

        public override Task Stop()
        {
            return Task.CompletedTask;
        }
        [RelayCommand]
        async Task Back()
        {
            await Shell.Current.GoToAsync("..", true);
        }
    }
}
