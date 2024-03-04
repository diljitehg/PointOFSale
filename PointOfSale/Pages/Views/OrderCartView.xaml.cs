using System.Windows.Input;

namespace PointOfSale.Pages.Views
{
    public partial class OrderCartView : ContentView
    {
        public ICommand PlaceOrderCommand { get; }

        public OrderCartView()
        {
            InitializeComponent();
            PlaceOrderCommand = new Command(ExecutePlaceOrderCommand);
        }

        private async void ExecutePlaceOrderCommand()
        {
            await Shell.Current.GoToAsync("//PointOfSale.Pages.Handheld.OrdersPage");
        }
    }
}
