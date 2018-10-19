using System;

namespace Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            string[] presents = {"lod", "auto", "mobil", "pocitac", "letadlo", "pc hru"};
            string[] names = {"Marek", "Filip", "Michal"};

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i] + " dostane ");

                for (int j = 0; j < 2; j++)
                {
                    int rnd = random.Next(0, presents.Length);

                    while(presents[rnd] == "nic")
                        rnd = random.Next(0, presents.Length);

                    if (j == 1)
                        Console.Write(presents[rnd]);
                    else
                        Console.Write(presents[rnd] + ", ");

                    presents[rnd] = "nic";


                }

                Console.WriteLine();
            }
            

            Console.ReadKey(true);
        }
    }
}
