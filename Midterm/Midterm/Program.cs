using System;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            /*
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
           */
             
           

            for (int e = 49; e >= 1; e--)
            {
                Console.Write(e);
                {
                    Console.Write(",");
                    if (e == 2)
                    {
                        Console.Write("");
                    }
                }
            }




        }
    }
}
