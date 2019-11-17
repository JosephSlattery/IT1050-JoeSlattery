using System;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            // The counter-controlled repetition consists of the initial value (where you want the loop to start), the increment (how much you want the initial value to increase or decrease by), the control variable (the point where you want the value to stop going up/down) and the loop-continuation condition (a true or false statement that tells the program to keep incrementing or to stop at the control cariable).
            // While statements run the body and go back and forth between the condition and body. If statements run everything in that statement until it the initial value reaches the control value before moving on to the body. 
            // You would use a do-while statment while asking a user for a password. The app will keep asking for the password until the statement becomes true, where a while statment wouldn't run at all.


            for (int i = 1; i < 100; i++)

            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(i + " it's even");
                }


                else
                    Console.WriteLine(i + " it's odd");
            }
                
                    
                
            
           

            
            Console.Write("Please endter a temperature:");
            double temperature = Convert.ToDouble(Console.ReadLine());
            if (temperature < 10)
            {
                Console.WriteLine("Polar Bear");
            }
            else if(temperature < 20)
            {
                Console.WriteLine("Penguin");
            }
            else if (temperature < 40)
            {
                Console.WriteLine("Moose");
            }
            else if (temperature < 50)
            {
                Console.WriteLine("Reindeer");
            }
            else if (temperature < 60)
            {
                Console.WriteLine("Deer");
            }
            else if (temperature < 70)
            {
                Console.WriteLine("Turtle");
            }
            else if (temperature < 80)
            {
                Console.WriteLine("Lion");
            }
            else if (temperature < 90)
            {
                Console.WriteLine("Fish");
            }
           


            int e = 10;
            while (e < 21)
            {
                Console.WriteLine(e++);
            }
            



            for (int u = 0; u < 101; u++)
            {
                Console.WriteLine(u);
                Console.WriteLine("********");
                
            }
            
        }
    }
}
