using System;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Single selection and while statements can execute a statement based on the value of a bool. A single selection statement can execute multiple statements with 'else' or 'ifElse' statements following. While statments only execute one statement at a time.


         
               int speedLimit = 35;
               int speed = 42;

               if (speed > speedLimit)
               {
                   Console.WriteLine("SLOW NOW");
               }






               bool itsTrue = true;

               if (itsTrue == true)
               {
                   Console.WriteLine("It is True!");
               }

               if (itsTrue == false)
                   {
                   Console.WriteLine("It is False!");
               }







               double celsius;
               Console.Write("Enter tempature in fahrengeit:");
               double fahrenheit = Convert.ToDouble(Console.ReadLine());

               celsius = (fahrenheit - 32d) * 5d / 9d;
               Console.WriteLine(celsius);

               if (fahrenheit < 40)
               {
                   Console.WriteLine("It is cold");
                       }
               if (fahrenheit > 90)
               {
                   Console.WriteLine("It is hot");
              }






            int c =1;
            while (c < 11)
                Console.WriteLine(c++);

    
            int i = 65;
            while (i > 19)
                Console.WriteLine(i = i - 5);
            
            int j = 8;
            while (j < 20)
                Console.WriteLine(j = j + 2);
        }
    }
}
