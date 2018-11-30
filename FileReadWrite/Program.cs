using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileReadWrite
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Jako hodně jejda  
            
            string cestaSoub = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DataHehe.txt";

            int a = 5;
            int b = 6;
            int c = 7;
            
            File.WriteAllText(cestaSoub, $"{a}, {b}, {c}");

            string config = File.ReadAllText(cestaSoub);
            
            Console.WriteLine(config);
            
            // Zápis 100x x;y
            
            Random random = new Random();
            
            string cestaXYSoub = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DataHeheXY.txt";
            
            using (Stream soub = new FileStream(cestaXYSoub, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(soub, Encoding.UTF8))
                {
                    for (int i = 0; i < 100; i++)
                    {
                        int x = random.Next(0, 101);
                        int y = random.Next(0, 101);
                        
                        sw.WriteLine($"{x};{y}");
                    } 
                }
            }
            
            List<int> xs = new List<int>();
            List<int> ys = new List<int>();
            
            using (Stream soub = new FileStream(cestaXYSoub, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(soub, Encoding.UTF8))
                {
                    string radek;

                    while ((radek = sr.ReadLine()) != null)
                    {
                        string[] xy = radek.Split(';');
                        
                        int x = Convert.ToInt32(xy[0]);
                        int y = Convert.ToInt32(xy[1]);
                        
                        xs.Add(x);
                        ys.Add(y);
                        
                        Console.WriteLine($"x: {x}, y: {y}");
                    }
                }
            }
            
            Console.WriteLine("prumer x: {0}, prumer y: {1}", xs.Average(), ys.Average());
        }
    }
}