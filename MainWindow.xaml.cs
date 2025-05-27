using System.Windows;
using System.Collections.Generic;

namespace TSD_BookCollection
{
    public partial class MainWindow : Window
    {
        public List<Book> Books { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Books = MyBookCollection.GetMyCollection();
            DataContext = this;
        }
    }
}
