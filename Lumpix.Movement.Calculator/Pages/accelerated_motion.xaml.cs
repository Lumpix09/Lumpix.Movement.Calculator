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
    public partial class accelerated_motion : Page
    {
        public accelerated_motion()
        {
            InitializeComponent();
        }
        #region Event Handlers
        #region navigation
        private void btn_home_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
        #endregion
        #region calculations
        #region calculation of final position
        private void dusp_values_1_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            double d0 = dusp_start_pos_1.Value ?? 0;
            double v0 = dusp_velocity_1.Value ?? 0;
            double t = dusp_time_1.Value ?? 0;
            double t0 = dusp_start_time_1.Value ?? 0;
            double a = dusp_acceleration_1.Value ?? 0;

            double d = Math.Round(d0 + v0 * (t - t0) + 0.5 * a * Math.Pow(t - t0, 2), 3);

            lbl_final_position_1.Content = d.ToString();
        }

        private void dusp_values_2_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            double d0 = dusp_start_pos_2.Value ?? 0;
            double v0 = dusp_velocity_2.Value ?? 0;
            double t = dusp_time_2.Value ?? 0;
            double t0 = dusp_start_time_2.Value ?? 0;
            double a = dusp_acceleration_2.Value ?? 0;

            double d = Math.Round(d0 + v0 * (t - t0) + 0.5 * a * Math.Pow(t - t0, 2), 3);

            lbl_final_position_2.Content = d.ToString();
        }
        #endregion
        #region calculation of intersection
        private void btn_calc_intersection(object sender, RoutedEventArgs e)
        {
            double t1 = dusp_start_time_1.Value ?? 0;
            double v1 = dusp_velocity_1.Value ?? 0;
            double x1 = dusp_start_pos_1.Value ?? 0;
            double a1 = dusp_acceleration_1.Value ?? 0;
            double t2 = dusp_start_time_2.Value ?? 0;
            double v2 = dusp_velocity_2.Value ?? 0;
            double x2 = dusp_start_pos_2.Value ?? 0;
            double t01 = dusp_start_time_1.Value ?? 0;
            double a2 = dusp_acceleration_2.Value ?? 0;

            double t_solution1 = (-(v1 - a1 * t1 - v2 + a2 * t2) + Math.Sqrt(Math.Pow(v1 - a1 * t1 - v2 + a2 * t2, 2) - 2 * (a1 - a2) * (x1 - v1 * t1 + 0.5 * a1 * t1 * t1 - x2 + v2 * t2 - 0.5 * a2 * t2 * t2))) / (a1 - a2);
            double t_solution2 = (-(v1 - a1 * t1 - v2 + a2 * t2) - Math.Sqrt(Math.Pow(v1 - a1 * t1 - v2 + a2 * t2, 2) - 2 * (a1 - a2) * (x1 - v1 * t1 + 0.5 * a1 * t1 * t1 - x2 + v2 * t2 - 0.5 * a2 * t2 * t2))) / (a1 - a2);
            lbl_out_time_of_intersection.Content = Math.Round(t_solution1, 3).ToString() + " or " + Math.Round(t_solution2, 3).ToString();

            double d1 = Math.Round(x1 + v1 * (t_solution1 - t01) + 0.5 * a1 * Math.Pow(t_solution1 - t01, 2), 3);
            double d2 = Math.Round(x1 + v1 * (t_solution2 - t01) + 0.5 * a1 * Math.Pow(t_solution2 - t01, 2), 3);
            lbl_out_place_of_intersection.Content = d1.ToString() + " or " + d2.ToString();
        }
        #endregion
        #endregion
        #endregion
    }
}
