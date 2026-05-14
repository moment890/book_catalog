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
        private readonly BookContext _context = new();

        public ObservableCollection<Book> Books { get; } = new();
        public ObservableCollection<Category> Categories { get; } = new();
        public ObservableCollection<Genre> Genres { get; } = new();

        private void LoadData(object сategory) {
            throw new NotImplementedException();
        }

        private void LoadData(DocumentFormat.OpenXml.Drawing.Diagrams.Category category) {
            Books.Clear();
            foreach (var book in _context.Books.Include(b => b.Category).Include(b => b.Genre))
                Books.Add(book);

            Categories.Clear();
            foreach (var Сategory in _context.Categories)
                Categories.Add(Сategory);

            Genres.Clear();
            foreach (var genre in _context.Genres)
                Genres.Add(genre);
        }
    }
}