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

        public ObservableCollection<Book> Books { get; } = new();
        public ObservableCollection<Category> Categories { get; } = new();
        public ObservableCollection<Genre> Genres { get; } = new();

        [ObservableProperty]
        private string _searchText;

        [ObservableProperty]
       private Category _selectedCategory;

        public MainWindowViewModel() 
        {
            LoadData();
        }
        private async void LoadData() 
        {
            Books.Clear();
            Categories.Clear();
            Genres.Clear();

            Categories.Add(new Category() { Id = -1, Name = "Все", Books = Books });

            foreach (var product in await db.Books.ToListAsync()) 
            {
                Books.Add(product);
                Books.Add(product);
            }
            foreach (var category in await db.Categories.ToListAsync()) 
            {
                Categories.Add(category);
            }
        }
            partial void OnSearchTextChanged(string value)
            {
            ApplyFilters();
            }

            partial void OnSelectedCategoryChanged(Category value)
            {
            ApplyFilters();
            }
        private void ApplyFilters() {
            // Начинаем с запроса к базе данных
            IQueryable<Book> query = _context.Books;

            // Фильтр по названию (регистронезависимый)
            if (!string.IsNullOrWhiteSpace(_searchText)) {
                string lowerSearchText = _searchText.ToLower();
                query = query.Where(p => p.Name.ToLower().Contains(lowerSearchText));
            }

            object SelectedCategory = null;
            // Фильтр по категории
            if (SelectedCategory != null && SelectedCategory.Id != -1) 
            {
                query = query.Where(p => p.Category.Id == SelectedCategory.Id);
            }

            // Очищаем текущую коллекцию в UI
            Books.Clear();

            // Выполняем запрос к базе данных (ToList()) и добавляем результаты в коллекцию
            foreach (var item in query.ToList()) {
                Books.Add(item);
            }
        }

    }
}