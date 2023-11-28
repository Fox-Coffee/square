using System.Diagnostics;
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

/*
     Square: a program used to draw and calculate squares
    Copyright (C) 2023  Filip Kamieniecki

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

namespace WpfApp10
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void bok_tekst_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double b = Double.Parse(bok_tekst.Text);
                if (b > 0)
                {
                    pole_tekst.Text = (b * b).ToString();
                    obwod_tekst.Text = (b * 4).ToString();
                }
                else
                {
                    pole_tekst.Text = string.Empty;
                    obwod_tekst.Text = string.Empty;
                }
            } catch
            {
                pole_tekst.Text = string.Empty;
                obwod_tekst.Text = string.Empty;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bok_tekst.Text = string.Empty;
            pole_tekst.Text = string.Empty;
            obwod_tekst.Text = string.Empty;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                kwadrat.Width = Double.Parse(bok_tekst.Text) * 2;
                kwadrat.Height = Double.Parse(bok_tekst.Text) * 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void show_Checked(object sender, RoutedEventArgs e)
        {
            if(check.IsChecked == true)
            {
                kwadrat.Opacity = 0.5;
            }
            else
            {
                kwadrat.Opacity = 1;
            }
            check.IsEnabled = true;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            kwadrat.Opacity = 0.5;
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if(show.IsChecked == true)
            {
                kwadrat.Opacity = 1;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            kwadrat.Opacity = 0;
            check.IsEnabled = false;
            check.IsChecked = false;
        }
    }
}