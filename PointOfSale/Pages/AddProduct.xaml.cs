using System.ComponentModel;

namespace PointOfSale.Pages;

public partial class AddProduct : ContentPage
{
	public AddProduct()
	{
		InitializeComponent();
        BindingContext = new AddProductViewModel();

    }
    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}