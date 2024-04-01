namespace PointOfSale.Pages.Handheld;

[INotifyPropertyChanged]
[QueryProperty("Order", "Order")]
[QueryProperty("Added", "Added")]
public partial class OrderDetailsViewModel
{
    [ObservableProperty]
    Order order;

    [ObservableProperty]
    Item added;

    [RelayCommand]
    async Task Pay()
    {
        try
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "Order", order }
            };
            await Shell.Current.GoToAsync($"{nameof(TipPage)}", navigationParameter);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
    }

    [RelayCommand]
    async Task Add()
    {
        try
        {
            await Shell.Current.GoToAsync($"{nameof(AddProduct)}");
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error navigating to ScanPage: {ex.Message}");
        }
    }
}