using System;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            // p[0], p[1], p[2], p[3]
            
            
             string[] months = new string[12];
             months[0] = "1, January";
             months[1] = "2, February";
             months[2] = "3, March";
             months[3] = "4, April";
             months[4] = "5, May";
             months[5] = "6, June";
             months[6] = "7, July";
             months[7] = "8, August";
             months[8] = "9, September";
             months[9] = "10, October";
             months[10] = "11, November";
             months[11] = "12, December";
             for (int i = 0; i < months.Length; i++)
             {
                 Console.WriteLine(months[i]);
             }
        
            string[] seasons = new string[4];
            seasons[0] = "spring";
            seasons[1] = "summer";
            seasons[2] = "fall";
            seasons[3] = "winter";
            foreach (var season in seasons)
            {
                Console.WriteLine(season);
            }
            





            Random random = new Random();
            int randomNumber;
            int[] randomNumbers = new int[1000];

            {
                for (int i = 0; i < randomNumbers.Length; i++)
                {
                    randomNumber = random.Next(0, 1000);
                    randomNumbers[i] = randomNumber;
                }

                for (int i = 0; i < randomNumbers.Length; i++)
                {
                    Console.WriteLine($"{i + 1,4}.{randomNumbers[i]}");
                }

            }

            /*
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            int i = 0;
            foreach (var name in names)
            {
                Console.WriteLine("{0,0}. {1}", i, names[i++]);
            } 
       */
        }
    }
}
