using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Media;

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
            this.DeleteRequested += DeleteBook_Click;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public static readonly RoutedEvent DeleteRequestedEvent = EventManager.RegisterRoutedEvent(
    "DeleteRequested", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(MainWindow));

        public event RoutedEventHandler DeleteRequested
        {
            add { AddHandler(DeleteRequestedEvent, value); }
            remove { RemoveHandler(DeleteRequestedEvent, value); }
        }

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
        private void RaiseDeleteBookRequested(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(DeleteRequestedEvent));
        }


        private void DeleteBook_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedBook == null)
                return;

            var result = MessageBox.Show(
                $"Are you sure you want to delete '{SelectedBook.Title}'?",
                "Confirm Deletion",
                MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                Books.Remove(SelectedBook);
                SelectedBook = Books.FirstOrDefault();
                OnPropertyChanged(nameof(Books));
                OnPropertyChanged(nameof(SelectedBook));
            }
        }

        private void DarknessSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte darkness = (byte)e.NewValue;
            // Im mniejsza wartość, tym ciemniejsze tło (czyli mniej białe)
            this.Background = new SolidColorBrush(Color.FromRgb(darkness, darkness, darkness));
        }

    }
}