using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lumpix.Movement.Calculator
{
    /// <summary>
    /// Interaktionslogik für MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        #region button click events
        private void btn_uniform_motion_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new uniform_motion());
        }

        private void btn_accelerated_motion_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new accelerated_motion());
        }

        private void btn_circle_motion_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new circle_motion());
        }

        private void btn_swing_motion_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new swing_motion());
        }
        #endregion
    }
}
