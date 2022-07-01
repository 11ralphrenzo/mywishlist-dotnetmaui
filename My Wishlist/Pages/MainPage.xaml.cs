using My_Wishlist.ViewModels;

namespace My_Wishlist.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}

