using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using My_Wishlist.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace My_Wishlist.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            this.items = new ObservableCollection<WishItem>();
        }

        [ObservableProperty]
        ObservableCollection<WishItem> items;

        [ObservableProperty]
        string text;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrEmpty(this.Text))
                return;  
            items.Add(new WishItem { Name = Text });
        }

        [RelayCommand]
        void Delete(string name)
        {
            var item = items.FirstOrDefault(item => item.Name == name);

                if (item == null)
                return;

            items.Remove(item);
        }
    }
}
