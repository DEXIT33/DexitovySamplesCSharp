using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using System.Windows.Threading;

namespace Timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Render);

        private int pocet;

        private bool started;

        private bool reverse;

        private Random random = new Random();

        private const int tolerance = 10;

        private int randomNumber;

        private bool huhu;

        private int score;

        public MainWindow()
        {
            InitializeComponent();

            randomNumber = random.Next(0, 101);
            JujkyLabel.Content = randomNumber + "%";

            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timer.Tick += (sender, args) => {
                

                if (reverse)
                {
                    pocet--;

                    if (pocet < 0)
                    {
                        reverse = false;
                    }
                    else
                    {
                        JujkyProgressBar.Value = pocet;
                    }
                }
                else
                {
                    pocet++;

                    if (pocet > 100)
                    {
                        reverse = true;
                    }
                    else
                    {
                        JujkyProgressBar.Value = pocet;
                    }
                }     
            };
            timer.Start();

            started = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (huhu) return;

            timer.Stop();

            if (JujkyProgressBar.Value > randomNumber - tolerance / 2 - 1 &&
                JujkyProgressBar.Value < randomNumber + tolerance / 2 + 1)
            {
                JujkyDruhyLabel.Content = "SPRÁVNĚ!";
                score++;
            }
            else
            {
                JujkyDruhyLabel.Content = "ŠPATNĚ!";
                score--;   
            }

            JujkyScoreLabel.Content = "Score: " + score;
            huhu = true;

            Task.Delay(1000).ContinueWith(_ =>
                {
                    Dispatcher.Invoke(() =>
                    {
                        JujkyDruhyLabel.Content = "";
                        pocet = 0;
                        randomNumber = random.Next(0, 101);
                        JujkyLabel.Content = randomNumber + "%";
                        timer.Start();

                        huhu = false;
                    });
                }
            );
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                Button_Click(null, null);
            }
        }
    }
}
