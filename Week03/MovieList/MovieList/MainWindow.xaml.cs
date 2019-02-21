using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MovieList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Movie> movieList;

        public MainWindow()
        {
            InitializeComponent();

            movieList = new List<Movie>();
        }

        private void AddMovie_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReleaseYearInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TitleInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ShowAllButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
