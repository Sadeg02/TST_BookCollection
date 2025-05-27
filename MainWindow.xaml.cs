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
                    selectedBook = value;
                     PropertyChanged?.Invoke(this,
               new PropertyChangedEventArgs(nameof(selectedBook)));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            Books = MyBookCollection.GetMyCollection();
            SelectedBook = Books[0]; // Set default selected book
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
