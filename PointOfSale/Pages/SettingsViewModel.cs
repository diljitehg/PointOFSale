namespace PointOfSale.Pages;
using PointOfSale.Pages;
[INotifyPropertyChanged]
public partial class SettingsViewModel
{
    [ObservableProperty]
    ObservableCollection<Item> _products;

    public SettingsViewModel()
    {
        _products = new ObservableCollection<Item>(
            AppData.Items
        );
    }

    [RelayCommand]
    async Task NotImplemented()
    {
        if (Shell.Current != null && Shell.Current.Navigation != null)
        {
            await Shell.Current.GoToAsync("//OrdersViewPage");
        }
        else
        {
            
            await App.Current.MainPage.DisplayAlert("Not Implement Yet", "FYP", "OK");
        }
    }
}


