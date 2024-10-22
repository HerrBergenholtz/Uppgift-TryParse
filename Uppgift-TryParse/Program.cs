using System;

namespace Uppgift_TryParse
{
    class Program
    {
        static void Main()
        {
            int resultat = 0;

            while (true)
            {
                Console.WriteLine("Skriv en siffra");
                if (!TryParse(Console.ReadLine(), out resultat))
                {
                    Console.WriteLine("FEL! Skriv in en siffra");
                }
                else
                {
                    Console.WriteLine(resultat);
                }
            }
        }

        public static bool TryParse(string input, out int resultat)
        {
            try
            {
                resultat = int.Parse(input);
                return true;
            }
            catch (FormatException)
            {
                resultat = 0;
                return false;
            }
        }
    }
}