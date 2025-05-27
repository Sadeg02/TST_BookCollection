using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Collections.ObjectModel;

namespace TSD_BookCollection
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Book selectedBook;

public ObservableCollection<Book> Books { get; set; }

        public Book SelectedBook
        {
            get => selectedBook;
            set
            {
                if (selectedBook != value)
                {
                    selectedBook = value;
                    OnPropertyChanged();
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            Books = new ObservableCollection<Book>(MyBookCollection.GetMyCollection());
            SelectedBook = Books[0];
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void AddBook_Click(object sender, RoutedEventArgs e)
        {
            int nextId = Books.Any() ? Books.Max(b => b.Id) + 1 : 1;
            var newBook = new Book(nextId)
            {
                Title = "New Book",
                Author = "Author",
                Year = 2025,
                Format = BookFormat.EBook
            };
            Books.Add(newBook);
            SelectedBook = newBook; // Set the newly added book as selected
            OnPropertyChanged(nameof(Books));
            OnPropertyChanged(nameof(SelectedBook)); // Notify UI
        }


        private void DeleteBook_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedBook != null)
            {
                Books.Remove(SelectedBook);
                SelectedBook = Books.FirstOrDefault(); // or null
                OnPropertyChanged(nameof(Books));
                OnPropertyChanged(nameof(SelectedBook)); // Notify UI
            }
        }

    }
}
