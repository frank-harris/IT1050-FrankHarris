using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Both an IF and WHILE will permit a bit of code to be executed based on certain conditions that are met.
 * An IF can execute its code block ONE TIME ONLY, using any expressions that evaluate to TRUE or FALSE but a
 * WHILE loop will execute its code block repeatedly until the condition is FALSE.  
 * 
 * 
 * int speedlimit 35;
 * int speed 42;
 * if(speed > speedlimit)
 * {
 * Console.Write("SLOW NOW");
 * }
 * 
 * 
 * bool isTrue = false;
 * if(isTrue)
 * {
 * Console.Write("It is True");
 * } else
 * {
 * Console.Write("It is False");
 * }
 * 
 * 
 * 
 */


namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Temperature Conversion - Input a Farenheit temperature\n");

            int counter = 1;
            Console.Write("\n\nCounting by 1's \n");
            while(counter <=10)
            {
                Console.Write(counter + " " );
                counter += 1;
            }

            Console.Write("\n\nCounting 60-20 by 5's\n");
            counter = 60;
            while (counter >=20)
            {
                Console.Write(counter + " ");
                counter -= 5;
            }

            Console.Write("\n\nCounting 10-20 by 2's\n");
            counter = 10;
            while(counter <= 20)
            {
                Console.Write(counter + " ");
                counter += 2;
            }
            Console.ReadKey();
        }
    }
}
