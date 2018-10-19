using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32;

namespace ZapisCteniSouboru
{
    class Program
    {
        //Každý řádek 1 číslo od 1 do 100
        //Zjisti, které se generovalo nejčastěji

        static void Main(string[] args)
        {
            Random random = new Random();

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MojeData.txt";

            using (Stream stream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
            {
                using (StreamWriter streamWriter = new StreamWriter(stream, Encoding.UTF8))
                {
                    for (int i = 0; i < 100; i++)
                    {
                        streamWriter.WriteLine(random.Next(0, 11));
                    }                   
                }
            }

            using (Stream stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                using (StreamReader streamReader = new StreamReader(stream, Encoding.UTF8))
                {
                    int[] array = new int[100];

                    string line;
                    
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        array[Convert.ToInt32(line)] += 1;

                        Console.WriteLine(line);
                    }           

                    //TODO Change
                    Console.WriteLine(array.Max());
                }
            }

            Console.ReadKey(true);
        }
    }
}
