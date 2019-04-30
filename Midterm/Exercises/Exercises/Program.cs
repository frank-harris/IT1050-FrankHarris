using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("print [2] - [128]\n");
            int value = 2;
            while (value <= 64)
            {
                Console.Write("[" + value + "]\n");
                value += 2;
            }
            Console.Write("\nPrint 49-1, Press a key");
            Console.ReadKey();
            value = 49;
            while(value > 0)
            {
                Console.Write(value);
                if (value > 1)
                    Console.Write(", ");
                value -= 1;

            }
            Console.Write("\n\nPrint Odd numbers, press a key");
            Console.ReadKey();
            value = 1;
            while (value < 22)
            {
                Console.Write(value + " ");
                value += 2;
            }
            Console.Write("\nQuestion 7: The output is a single asterisk.  If we used a while loop instead the output would be nothing.");
            Console.Write("\nPress a key");
            Console.ReadKey();

            Console.Write("8: We use an ampersand to combine multiple boolean values, for example:\n");
            Console.Write(" if (!icyRain & !tornadoWarning) \n");
            bool icyRain=false;
            bool tornadoWarning=false;
            if (!icyRain & !tornadoWarning)
                Console.Write("Lets go Outside!\n\n");

            Console.Write("Extra Credit, Press a key");
            Console.ReadKey();


        
        }
    }
}
