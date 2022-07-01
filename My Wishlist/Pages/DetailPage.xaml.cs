using My_Wishlist.ViewModels;

namespace My_Wishlist.Pages;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}