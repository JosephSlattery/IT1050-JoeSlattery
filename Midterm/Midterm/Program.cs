using System;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            //sequence structures run statements in the exact order that they are written. 
            //Selection structures will run true statements and switch control to another statement once the condition is no longer true. 
            //Repetition structures will run statements multipole times until the condition is false. 

            bool keepLooping = true;

            while (keepLooping == true) 
            Console.WriteLine("true");
            


            int i = 2;
            {
                while (i < 128)
                {
                    Console.WriteLine("[" + i++ + "]");
                    if (i == 65)
                    {
                        break;
                    }

                }

            }
        
             
           
   
            for (int e = 49; e >= 2; e--)
            {
                Console.Write(e);
                {
                    Console.Write(",");
                    if (e == 2)
                    {
                        Console.Write("1");
                    }
                }
            }
         
            int a = 1;
            do
            {
                if (a % 2 != 0)
                {
                    Console.Write(" {0}", a);
                }
                a++;
            } while (a <= 21);




            //The output is "10" since the statement still runs even if it is false
            // There is no output with a while statement, because it is a false statement.


            //You can put two conditions inside an if loop if you place "&&" between them. 


            bool icyRain = false;
            bool tornadoWarning = false;

            if (icyRain == false && tornadoWarning == false)
            {
                Console.WriteLine("let's go outside!");
            }
          

            
            }  
    }
}

