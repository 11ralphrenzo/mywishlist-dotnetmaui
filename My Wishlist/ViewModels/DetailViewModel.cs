using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using My_Wishlist.Models;
using My_Wishlist.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Wishlist.ViewModels
{
    [QueryProperty("Item", "item")]
    public partial class DetailViewModel : ObservableObject
    {
        [ObservableProperty]
        WishItem item;

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
