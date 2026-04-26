using book_catalog.Data;
using book_catalog.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Channels;

namespace book_catalog.ViewModels

{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private readonly BookContext db = new();

        private List<Title_Books> _allTitle_Books = new();
        public ObservableCollection<Title_Books> Title_Books { get; set; } = new();
        public ObservableCollection<Genre_Books> Genre_Books { get; set; } = new();
        public ObservableCollection<Categories_Books> Categories_Books { get; set; } = new();

        [ObservableProperty]
        private string _searchText;

        [ObservableProperty]
        private Categories_Books _selectedCategories_Books;
        [ObservableProperty]
        private Genre_Books _selectedGenre_Books;
        [ObservableProperty]
        private Title_Books _selectedTitle_Books;


        public MainWindowViewModel() 
        {
            LoadData();
          
        }

        private async void LoadData()
        {
            Categories_Books.Clear();
            Genre_Books.Clear();
            Title_Books.Clear();



        }
    }
}
