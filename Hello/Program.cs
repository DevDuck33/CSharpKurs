using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                PodajImie();
                PodajWiek();
                ResetKonsoli();
            }
        }

        private static void ResetKonsoli()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

        private static void PodajWiek()
        {
            int Wiek;
            Console.Write("Podaj swój wiek: ");
            bool wynik = int.TryParse(Console.ReadLine(), out Wiek);
                    //Parse to konwersja string na int
                    //TryParse konwersja która zwraca true jeżeli przebiegła pomyślnie przekazując wiek do "Out Wiek"

            if (wynik == false)
            {
                Console.WriteLine("Wpisałeś coś innego niż wiek !");
            }
            else
            {
                if (Wiek < 18)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Możesz kupić wodę :(");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Możesz kupić alkohol :)");
                }
            }
        }

        private static void PodajImie()
        {
            string Imie;
            Console.Write("Wpisz swoje imie: ");
            Imie = Console.ReadLine();
            Console.WriteLine("Witaj " + Imie);
        }
    }
}
