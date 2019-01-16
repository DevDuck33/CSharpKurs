using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string Imie;
            int Wiek;
            Console.Write("Wpisz swoje imie: ");
            Imie = Console.ReadLine();
            Console.WriteLine("Witaj " + Imie);

            Console.Write("Podaj swój wiek: ");
            bool wynik= int.TryParse(Console.ReadLine(),out Wiek);       //Parse to konwersja string na int
                                                                         //TryParse konwersja która zwraca true jeżeli przebiegła pomyślnie przekazując wiek do "Out Wiek"
            if (wynik == false)
            {
                Console.WriteLine("Wpisałeś coś innego niż wiek !");
            }
            else
            {
                if (Wiek < 18)
                {
                    Console.WriteLine("Możesz kupić wodę :(");
                }
                else
                {
                    Console.WriteLine("Możesz kupić alkohol :)");
                }
            }

            Console.ReadKey();
        }
    }
}
