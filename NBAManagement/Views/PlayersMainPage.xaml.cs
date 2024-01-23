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

            PlayersDataGrid.MouseDoubleClick += PlayersDataGrid_MouseDoubleClick;
        }

        private void OnSetFirstCharInNameFilterClick(object sender, RoutedEventArgs e)
        {
            var senderButton = (Button)sender;
            radioForegroundControlHighlighter.HighlightControl(senderButton);
        }

        private void PlayersDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (PlayersDataGrid.SelectedItem != null)
            {
                // Предполагая, что ваш ViewModel установлен как DataContext
                PlayersMainViewModel.PlayersMainPlayerItemViewModel selectedPlayer = (PlayersMainViewModel.PlayersMainPlayerItemViewModel)PlayersDataGrid.SelectedItem;

                // Выполнить команду OpenPlayerDetailCommand для выбранного игрока
                selectedPlayer.OpenPlayerDetailCommand.Execute(null);
            }
        }
    }
}
