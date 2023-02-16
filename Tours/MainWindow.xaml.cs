using System;
using System.Collections.Generic;
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

namespace Tours
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new HotelsPage());
            Meneger.MainFrame = MainFrame;
        }

        private void ImportTours()
        {
            var fileData = File.ReadAllLines(@"");
        }
        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                BinBack.Visibility = Visibility.Visible;
            }
            else
            {
                BinBack.Visibility = Visibility.Hidden;
            }
        }

        private void BinBack_Click(object sender, RoutedEventArgs e)
        {

            Meneger.MainFrame.GoBack();
        }
    }
}
