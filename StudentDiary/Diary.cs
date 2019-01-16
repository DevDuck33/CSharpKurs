using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {
        // Stan (Zmienne - Pola)

        List<float> Ratings;


        //Zachowania

        public void AddRating (float Rating)
        {
            Ratings.Add(Rating);
        }

        public float CalculateAverage()
        {
            float Sum = 0, Avg = 0;
            foreach (var Rating in Ratings)     //Dla każdego elementu z Ratings
            {
                Sum += Rating;
            }

            Avg = Sum / Ratings.Count();        //Count da nam ilość elementów w kolekcji
            return Avg;
        }

        public float GiveMaxRating()
        {
            return Ratings.Max();       //Zwraca największy element na liście
        }

        public float GiveMinRating()
        {
            return Ratings.Min();       //Zwraca najmniejszy element na liście
        }
    }
}
