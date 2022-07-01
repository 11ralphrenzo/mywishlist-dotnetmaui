﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using My_Wishlist.Models;
using My_Wishlist.Pages;
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
        void Delete(WishItem item)
        {
            var i = items.FirstOrDefault(it => it.Name == item.Name);

            if (i == null)
                return;

            items.Remove(item);
        }

        [RelayCommand]
        async Task Tap(WishItem item)
        {
            await Shell.Current.GoToAsync(nameof(DetailPage), 
                new Dictionary<string, object> { { "item", item } });
        }
    }
}
