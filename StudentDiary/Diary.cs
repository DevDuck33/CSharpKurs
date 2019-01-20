using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {
        // Stan (Zmienne - Pola)

        List<float> Ratings = new List<float>();


        //Zachowania

        public void AddRating (float Rating)
        {
            Ratings.Add(Rating);
        }

        internal DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics Stats = new DiaryStatistics();

            float Sum = 0;

            foreach (var Rating in Ratings)     //Dla każdego elementu z Ratings
            {
                Sum += Rating;
            }

            Stats.AverageGrade = Sum / Ratings.Count();

            Stats.MaxGrade = Ratings.Max();     //Największa watrość
            Stats.MinGrade = Ratings.Min();     //Najmniejsza watrość

            return Stats;
        }
    }
}
