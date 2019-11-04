using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1; // dec;are first number to add
            int number2; // declare second number to add
            int sum; // declare sum of number1 and number2

            Console.Write("Enter first integer:"); //prompt user
            // read first number from user
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer:"); // prompt user
            // read second number from user
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2; // add numbers

            Console.WriteLine("sum is {0}", sum); // display sum
            Console.WriteLine("{0}\n{1}", "Hello world", "from Joe Slattery");
          
       
           /*
            1. the app executes at line 11.
            2. a integer is a whole number and a double/float is a decimal.
            3. in a separate set of currly braces you can make a string, give it a name, place values assigned to that name, and recal that information by writing the name in the place of the value.
            4. set accessor, get accessor
            5. 
           */
        }
    }
}