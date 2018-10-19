using System;

namespace RandomUloha
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            string[] karty = {"sedmička", "osmička", "devítka", "desítka", "spodek", "svršek", "král", "eso"};
            string[] barvy = {"listy", "kule", "srdce", "žaludy"};

            string[] balicek = new string[32];

            int index = 0;

            for (int i = 0; i < karty.Length; i++)
            {
                for (int j = 0; j < barvy.Length; j++)
                {
                    balicek[index] = barvy[j] + " " + karty[i];
                    index++;
                }
            }

            ZamichejKarty(balicek);

            for (int i = 0; i < balicek.Length; i++)
            {
                Console.WriteLine(balicek[i]);
            }

            Console.ReadKey();
        }

        private static void ZamichejKarty(string[] balicek)
        {
            for (int i = 0; i < 200; i++)
            {
                int index0 = random.Next(0, balicek.Length);
                int index1 = random.Next(0, balicek.Length);

                string temp = balicek[index0];

                balicek[index0] = balicek[index1];
                balicek[index1] = temp;
            }
        }
    }
}
