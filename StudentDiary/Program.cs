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
                    Console.WriteLine("Zakończyłeś wprowadzanie");
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
            float Average = Diary.CalculateAverage();
            float Max = Diary.GiveMaxRating();
            float Min = Diary.GiveMinRating();

            Console.WriteLine("Średnia ocen to: " + Average);
            Console.WriteLine("Najwyższa ocena to: " + Max);
            Console.WriteLine("Najniższa ocena to: " + Min);
            Console.ReadKey();
        }
    }
}
