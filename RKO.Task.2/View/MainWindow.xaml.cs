using RKO.Task._2.Core;
using RKO.Task._2.View.Pages;
using System.ComponentModel;
using System.Windows;

namespace RKO.Task._2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CoreNavigate.MyConnection = MainFrame;
            MainFrame.Navigate(new MainPage());
        }
    }
}
