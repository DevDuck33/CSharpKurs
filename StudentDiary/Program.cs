using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary Diary = new Diary();      //Tworzymy nową inswtancje klasy Dairy
            
            for(; ; )
            {
                float Rating;

                Console.Write("Podaj liczę z zakresu 1-10 (inne zakończą wporwadzanie):");
                bool result = float.TryParse(Console.ReadLine(),out Rating);

                if (Rating > 10 || Rating < 1)
                {
                    Console.WriteLine("Zakończyłeś wprowadzanie" + "\n");
                    break;
                }
                else
                {
                    if (result == true)
                    {
                        Diary.AddRating(Rating);
                    }
                }

            }

            DiaryStatistics Stats = Diary.ComputeStatistics();      //Tworzymy nową zmienną klasy DiaryStatistics i przypisujemy jej wyniki obliczeń z Klasy Diary

            Console.WriteLine("Średnia ocen to: " + Stats.AverageGrade);
            Console.WriteLine("Najwyższa ocena to: " + Stats.MaxGrade);
            Console.WriteLine("Najniższa ocena to: " + Stats.MinGrade);

            Console.WriteLine("\n"+"Twój znajomy miał: ");
            Diary Diary2 = new Diary();     //Tworzymy kolejną inswtancje klasy Dairy

            Diary2.AddRating(1);
            Diary2.AddRating(10);
            Diary2.AddRating(9);

            Stats = Diary2.ComputeStatistics();     //Przypisujemy nowe wartości zmiennej Stats i wykonujemy na nich obliczenia

            Console.WriteLine("Średnia ocen to: " + Stats.AverageGrade);
            Console.WriteLine("Najwyższa ocena to: " + Stats.MaxGrade);
            Console.WriteLine("Najniższa ocena to: " + Stats.MinGrade);
            Console.ReadKey();
        }
    }
}
