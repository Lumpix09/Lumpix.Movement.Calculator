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
    /// Interaktionslogik für uniform_motion.xaml
    /// </summary>
    public partial class uniform_motion : Page
    {
        public uniform_motion()
        {
            InitializeComponent();
        }
        private void btn_home_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }
}
