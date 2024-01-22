using NBAManagement.Models;
using NBAManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace NBAManagement.Views
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
            ObservableCollection<Season> seasons = new ObservableCollection<Season>(Season.TestSeason);

            Season[] test = Season.TestSeason;
            Season[] test2 = Season.TestSeason;
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = await Task.Run(() => new StartViewModel());
        }
    }
}
