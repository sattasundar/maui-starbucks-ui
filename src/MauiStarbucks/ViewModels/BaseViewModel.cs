namespace MauiStarbucks.ViewModels
{
    public abstract class BaseViewModel: IViewModel
    {
        public BaseViewModel() { }
        public abstract Task Initialize();
        public abstract Task Stop();
    }
    public interface IViewModel
    {
        Task Initialize();
        Task Stop();
    }
}
