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

    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }

        private void BtnMainPage_Click(object sender, RoutedEventArgs e)
        {
            CoreNavigate.MyConnection?.Navigate(new MainPage());
        }

        private void BtnTask2_1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int X = 0, Y = 1, Z = 0;
                MessageBox.Show($"rX ={X & ~(Z | Y) | ~Z}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void BtnTask2_2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int X = 0, Y = 1, Z = 0;
                MessageBox.Show($"rY ={~X | X & (Y | Z)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void BtnTask2_3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int X = 0, Y = 1, Z = 0;
                MessageBox.Show($"rZ ={(X | X & ~Z) & Z}", "Системное сообщение",
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
