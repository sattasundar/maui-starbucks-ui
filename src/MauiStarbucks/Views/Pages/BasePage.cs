namespace MauiStarbucks.Views.Pages
{
    public class BasePage : ContentPage
    {
        public IViewModel ViewModel => (IViewModel)BindingContext;
        public BasePage()
        {

        }

        protected async override void OnAppearing()
        {
            await ViewModel.Initialize();
            base.OnAppearing();
        }

        protected async override void OnDisappearing()
        {
            await ViewModel.Stop();
            base.OnDisappearing();
        }
    }
}
