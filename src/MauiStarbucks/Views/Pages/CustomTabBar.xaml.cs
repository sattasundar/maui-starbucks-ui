using System.Windows.Input;

namespace MauiStarbucks.Views.Pages;

public partial class CustomTabBar : BasePage
{
    public static readonly BindableProperty SelectedTabIndexProperty = BindableProperty.Create(nameof(SelectedTabIndex), typeof(int), typeof(CustomTabBar), propertyChanged: (obj, old, newV) =>
    {
        var me = obj as CustomTabBar;
        if (newV != null && !(newV is int)) return;
        var oldSelectedIndex = (int)old;
        var newSelectedIndex = (int)newV;
        me?.SelectedTabIndexChanged(oldSelectedIndex, newSelectedIndex);
    });
    private void SelectedTabIndexChanged(int oldTabSelectedIndex, int newTabSelectedIndex) { }
    public int SelectedTabIndex
    {
        get => (int)GetValue(SelectedTabIndexProperty);
        set => SetValue(SelectedTabIndexProperty, value);
    }
    public static readonly BindableProperty ViewContentProperty = BindableProperty.Create(nameof(ViewContent), typeof(View), typeof(CustomTabBar), propertyChanged: (obj, old, newV) =>
    {
        var me = obj as CustomTabBar;
        if (newV != null && !(newV is View)) return;
        var oldViewContent = (View)old;
        var newViewContent = (View)newV;
        me?.ViewContentChanged(oldViewContent, newViewContent);
    });
    private void ViewContentChanged(View oldViewContent, View newViewContent) { }
    public View ViewContent
    {
        get => (View)GetValue(ViewContentProperty);
        set => SetValue(ViewContentProperty, value);
    }

    #region Commands
    //home
    public static readonly BindableProperty HomeTappedCommandProperty = BindableProperty
        .Create(nameof(HomeCommand), typeof(ICommand), typeof(CustomTabBar), propertyChanged: (obj, old, newV) =>
    {
        var me = obj as CustomTabBar;
        if (newV != null && !(newV is Type)) return;
        var oldTappedCommand = (Type)old;
        var newTappedCommand = (Type)newV;
        me?.HomeTappedCommandChanged(oldTappedCommand, newTappedCommand);
    });
    private void HomeTappedCommandChanged(Type oldTappedCommand, Type newTappedCommand) { }
    public ICommand HomeCommand
    {
        get => (ICommand)GetValue(HomeTappedCommandProperty);
        set => SetValue(HomeTappedCommandProperty, value);
    }
    //wallet
    public static readonly BindableProperty WalletTappedCommandProperty = BindableProperty
     .Create(nameof(WalletCommand), typeof(ICommand), typeof(CustomTabBar), propertyChanged: (obj, old, newV) =>
     {
         var me = obj as CustomTabBar;
         if (newV != null && !(newV is Type)) return;
         var oldTappedCommand = (Type)old;
         var newTappedCommand = (Type)newV;
         me?.WalletTappedCommandChanged(oldTappedCommand, newTappedCommand);
     });
    private void WalletTappedCommandChanged(Type oldTappedCommand, Type newTappedCommand) { }
    public ICommand WalletCommand
    {
        get => (ICommand)GetValue(WalletTappedCommandProperty);
        set => SetValue(WalletTappedCommandProperty, value);
    }
    //fav
    public static readonly BindableProperty FavTappedCommandProperty = BindableProperty
     .Create(nameof(FavCommand), typeof(ICommand), typeof(CustomTabBar), propertyChanged: (obj, old, newV) =>
     {
         var me = obj as CustomTabBar;
         if (newV != null && !(newV is Type)) return;
         var oldTappedCommand = (Type)old;
         var newTappedCommand = (Type)newV;
         me?.FavTappedCommandChanged(oldTappedCommand, newTappedCommand);
     });
    private void FavTappedCommandChanged(Type oldTappedCommand, Type newTappedCommand) { }
    public ICommand FavCommand
    {
        get => (ICommand)GetValue(FavTappedCommandProperty);
        set => SetValue(FavTappedCommandProperty, value);
    }
    //notification
    public static readonly BindableProperty NotificationTappedCommandProperty = BindableProperty
     .Create(nameof(NotificationCommand), typeof(ICommand), typeof(CustomTabBar), propertyChanged: (obj, old, newV) =>
     {
         var me = obj as CustomTabBar;
         if (newV != null && !(newV is Type)) return;
         var oldTappedCommand = (Type)old;
         var newTappedCommand = (Type)newV;
         me?.NotificationTappedCommandChanged(oldTappedCommand, newTappedCommand);
     });
    private void NotificationTappedCommandChanged(Type oldTappedCommand, Type newTappedCommand) { }
    public ICommand NotificationCommand
    {
        get => (ICommand)GetValue(NotificationTappedCommandProperty);
        set => SetValue(NotificationTappedCommandProperty, value);
    }
    #endregion
    public CustomTabBar()
    {
        InitializeComponent();
        //viewRowHeight.Height = AppLocator.DisplayHeight;
        HomeCommand = new Command(() => Shell.Current.GoToAsync("///starbucks/home"));
        WalletCommand = new Command(() => Shell.Current.GoToAsync("///starbucks/wallet"));
        FavCommand = new Command(() => Shell.Current.GoToAsync("///starbucks/fav"));
        NotificationCommand = new Command(() => Shell.Current.GoToAsync("///starbucks/notification"));
    }
}