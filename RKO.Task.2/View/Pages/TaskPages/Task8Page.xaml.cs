using RKO.Task._2.Core;
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

namespace RKO.Task._2.View.Pages.TaskPages
{
    public partial class Task8Page : Page
    {
        public Task8Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }

        private void BtnTask8_1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = 1, y = 2;
                MessageBox.Show($"rX ={(x >= 0) && (Math.Pow(y,2) != 4)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnTask8_2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int x = 2, y = 1;
                MessageBox.Show($"rY ={(x * y < 0) && (y < x)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
