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

namespace Tetrisz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow _Main;
        public MainWindow()
        {
            InitializeComponent();
            _WP_Grid.Width = 35 * 10;
            _WP_Grid.Height = 35 * 20;
            _Main = this;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Game_BackEnd.Start_Game();
        }
    }
}
