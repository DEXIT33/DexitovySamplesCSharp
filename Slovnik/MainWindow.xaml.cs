using System;
using System.Collections.Generic;
using System.IO;
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

namespace Slovnik
{
    public partial class MainWindow : Window
    {
        string sourcePath = @"/source.txt";

        private bool englishToCzech = true;

        private Dictionary<string, string> data;

        public MainWindow()
        {
            InitializeComponent();

            data = new Dictionary<string, string>();

            ReadData();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateResult();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            englishToCzech = true;
            englishCzechButton.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            czechEnglishButton.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            UpdateResult();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            englishToCzech = false;
            czechEnglishButton.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            englishCzechButton.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            UpdateResult();
        }

        private void UpdateResult()
        {
            resultLabel.Content = "";

            if(String.IsNullOrEmpty(textBox.Text))
                return;
            
            foreach (KeyValuePair<string, string> entry in data)
            {
                if (englishToCzech)
                {
                    if (textBox.Text.ToLower().Equals(entry.Key))
                        resultLabel.Content = entry.Value;
                }
                else
                {
                    if (textBox.Text.ToLower().Equals(entry.Value))
                        resultLabel.Content = entry.Key;
                }
            }
        }

        private void ReadData()
        {
            data.Clear();

            using (Stream soub = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(soub, Encoding.UTF8))
                {
                    int i = 0;

                    string radek;
                    while ((radek = sr.ReadLine()) != null)
                    {
                        i++;

                        try
                        {
                            String[] splitted = radek.Split(';');

                            data.Add(splitted[0], splitted[1]);
                        }
                        catch
                        {
                            Console.WriteLine("Chyba radek: {0}. - {1}", i, radek);
                        }                     
                    }
                }
            }
        }

        private void addWordButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(englishInput.Text) || String.IsNullOrEmpty(czechInput.Text) || String.IsNullOrWhiteSpace(englishInput.Text) || String.IsNullOrWhiteSpace(czechInput.Text) || data.ContainsKey(englishInput.Text))
                return;

            using (Stream soub = new FileStream(sourcePath, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(soub, Encoding.UTF8))
                {
                    sw.WriteLine(englishInput.Text + ";" + czechInput.Text);
                }
            }

            ReadData();
        }
    }
}
