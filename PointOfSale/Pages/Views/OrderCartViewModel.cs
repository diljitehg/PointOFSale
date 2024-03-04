using System;
namespace PointOfSale.Pages.Views;

[INotifyPropertyChanged]
public partial class OrderCartViewModel
{
    [ObservableProperty]
    Order order;

    public OrderCartViewModel()
    {
        Order = AppData.Orders.First();
    }

    [RelayCommand]
    async Task PlaceOrder()
    {
     //   await Shell.Current.GoToAsync("//PointOfSale.Pages.Handheld.OrdersPage");
        await App.Current.MainPage.DisplayAlert("Not Implemented", "Just for FYP", "Okay");
    }
}