using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Morseovka
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Dobry den";
            str = str.ToLower();

            string[] mor = 
            {
                ".-",
                "-...",
                "-.-.",
                "-..",
                ".",
                "..-.",
                "--.",
                "....",
                "..",
                ".---",
                "-.-",
                ".-..",
                "--",
                "-.",
                "---",
                ".--.",
                "--.-",
                ".-.",
                "...",
                "-",
                "..-",
                "...-",
                ".--",
                "-..-",
                "-.--",
                "--.."
            };

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    string morChar = mor[str[i] - 'a'];

                    Console.Write("{0}/", morChar);

                    for (int j = 0; j < morChar.Length; j++)
                    {
                        if(morChar[j] == '.')
                            Console.Beep(3000, 150);
                        else
                            Console.Beep(3000, 800);
                    }

                }

                if (str[i] == ' ')
                {
                    Console.Write("//");
                    Thread.Sleep(1000);
                }
                    
            }
        }
    }
}
