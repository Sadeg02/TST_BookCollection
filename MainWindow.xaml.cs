using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace TSD_BookCollection
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Book selectedBook;

        public List<Book> Books { get; set; }

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
            Books = MyBookCollection.GetMyCollection();
            SelectedBook = Books[0];
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
