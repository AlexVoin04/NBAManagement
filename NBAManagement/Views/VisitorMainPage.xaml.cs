using NBAManagement.ViewModels;
using NBAManagement.Views;
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

namespace NBAManagement.Views
{
    /// <summary>
    /// Interaction logic for VisitorMainPage.xaml
    /// </summary>
    public partial class VisitorMainPage : Page
    {
        public VisitorMainPage()
        {
            InitializeComponent();
            DataContext = new VisitorMainViewModel();
        }
    }
}
