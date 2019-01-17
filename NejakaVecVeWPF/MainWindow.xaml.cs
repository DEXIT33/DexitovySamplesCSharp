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

namespace NejakaVecVeWPF
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Content)
                {
                    case "+":
                        Label0.Content = Convert.ToDouble(TextBox1.Text) + Convert.ToDouble(TextBox2.Text);
                        break;
                    case "-":
                        Label0.Content = Convert.ToDouble(TextBox1.Text) - Convert.ToDouble(TextBox2.Text);
                        break;
                    case "*":
                        Label0.Content = Convert.ToDouble(TextBox1.Text) * Convert.ToDouble(TextBox2.Text);
                        break;
                    case "/":
                        Label0.Content = Convert.ToDouble(TextBox1.Text) / Convert.ToDouble(TextBox2.Text);
                        break;
                }
            }
        }
    }
}
