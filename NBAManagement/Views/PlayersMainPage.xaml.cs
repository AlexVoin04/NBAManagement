using NBAManagement.Models;
using NBAManagement.Filter;
using System;
using System.Collections.Generic;
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
using NBAManagement.ViewModels;
using static NBAManagement.ViewModels.PlayersMainViewModel;

namespace NBAManagement.Views
{
    /// <summary>
    /// Логика взаимодействия для PlayersMainPage.xaml
    /// </summary>
    public partial class PlayersMainView : Page
    {
        private readonly RadioForegroundControlHighlighter radioForegroundControlHighlighter;
        public PlayersMainView()
        {
            InitializeComponent();
            radioForegroundControlHighlighter = new RadioForegroundControlHighlighter
            (
                (SolidColorBrush)FindResource("ButtonHighlightColor"),
                (SolidColorBrush)FindResource("ButtonStandartColor")
            );
            DataContext = new PlayersMainViewModel();
            radioForegroundControlHighlighter.HighlightControl(FirstCharInNameFilterAllButton);
        }

        private void OnSetFirstCharInNameFilterClick(object sender, RoutedEventArgs e)
        {
            var senderButton = (Button)sender;
            radioForegroundControlHighlighter.HighlightControl(senderButton);
        }

        private void PlayersDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var viewModel = DataContext as PlayersMainViewModel;

            if (viewModel != null)
            {
                // Получите выбранный элемент из DataGrid
                var selectedPlayerItem = PlayersDataGrid.SelectedItem as PlayersMainPlayerItemViewModel;

                // Проверьте, что элемент не null и выполните команду
                if (selectedPlayerItem != null)
                {
                    viewModel.OpenPlayerDetailCommand.Execute(null);
                }
            }
        }
    }
}
