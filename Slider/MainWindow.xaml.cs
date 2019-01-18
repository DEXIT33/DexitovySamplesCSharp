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

namespace Slider
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged_0(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Label0.Content = (int)Slider0.Value;
            UpdateColor();
        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Label1.Content = (int)Slider1.Value;
            UpdateColor();
        }

        private void Slider_ValueChanged_2(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Label2.Content = (int)Slider2.Value;
            UpdateColor();
        }

        private void UpdateColor()
        {
            Rectangle0.Fill = new SolidColorBrush(Color.FromRgb((byte)Slider0.Value, (byte)Slider1.Value, (byte)Slider2.Value));
        }
    }
}
