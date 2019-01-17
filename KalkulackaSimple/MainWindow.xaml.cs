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

namespace KalkulackaSimple
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

        private void ButtonClickNumber(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                InputTextBox.Text += button.Tag;
            }
        }

        private void ButtonClickOperation(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if (!button.Tag.Equals("="))
                {
                    if (InputTextBox.Text.ToCharArray().Last() != '+' && InputTextBox.Text.ToCharArray().Last() != '-')
                        InputTextBox.Text += button.Tag;
                }
                else
                {
                    Evaluate();
                }
            }
        }

        private void Evaluate()
        {
            // TODO
        }
    }
}
