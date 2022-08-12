namespace MauiStarbucks.Models
{
    [INotifyPropertyChanged]
    public partial class Product
    {
        [ObservableProperty]
        public int productId;
        [ObservableProperty]
        public string productType;
        [ObservableProperty]
        public string productName;
        [ObservableProperty]
        public string productImgUrl;
        [ObservableProperty]
        public Color productImgBackground;
        [ObservableProperty]
        public double productBasePrice;
        [ObservableProperty]
        public double productPrice;
        [ObservableProperty]
        public string productDescription;
        [ObservableProperty]
        public bool productIsFav;
        [RelayCommand]
        void ProductFav()
        {
            ProductIsFav = !ProductIsFav;
        }
        [ObservableProperty]
        public string productSizeType;
        partial void OnProductSizeTypeChanged(string value)
        {
            if (value.Equals("Grande"))
                ProductPrice = ProductBasePrice + 20.00;
            else if (value.Equals("Venti"))
                ProductPrice = ProductBasePrice + 50.00;
            else
                ProductPrice = ProductBasePrice;
        }
    }
    [INotifyPropertyChanged]
    public partial class ProductSize
    {
        [ObservableProperty]
        public string productSizeImgUrl;
        [ObservableProperty]
        public string productSizeName;
    }
}
