using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * The four elements of a for loop are:
    1-creating/setting a control variable
    2-setting the initial value
    3-setting the condition to continue the loop
    4-increment/decrement the variable

    The while and for loops are nearly identical and can be used interchangably but most often the
    while loop is set to run continuously until a condition is false and a for loop is most often set to run
    a specified amount of iterations over the code block.. 
    The while loop is simpler than the usual format of the for loop.
    Consider this configuration of the for loop which works identical to a while loop
    for(counter = true;counter==true;){
     }
    the code will run until counter is set to false inside the block which could be when an Exit key is pressed or
    any other trigger commonly used by a while loop.  


    A do-while loop would be preferred when the code block must be run at least one time.  The conditional expression is
    evaluated at the end of the loop rather than before as in a while() loop.
    Example might be when you need to initialize program configurations and some variables need to be set. 
 * */


namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; //declared here because its used in global and local scope below
            Console.Write("Output 1-100 and output if even or odd");
            Console.ReadKey();
            for (i=1;i<=100;i++)
            {
                if ((i % 2) == 0)
                {
                    Console.Write("Even\n");
                } else
                {
                    Console.Write("Odd\n");
                }

            }

            Console.Write("Please enter a temperature ");
            int temp = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            if(temp < 10)
            {
                Console.Write("Polar Bear");
            }else if(temp < 20)
            {
                Console.Write("Penguin");
            }
            else if (temp < 30)
            {
                Console.Write("Moose");
            }
            else if (temp < 40)
            {
                Console.Write("Reindeer");
            }
            else if (temp < 50)
            {
                Console.Write("Deer");
            }
            else if (temp < 60)
            {
                Console.Write("Turtle");
            }
            else if (temp < 70)
            {
                Console.Write("Lion");
            }
            else if (temp < 80)
            {
                Console.Write("Fish");
            }
            else 
            {
                Console.Write("Bug");
            }

            Console.Write("\n");
            Console.Write("Print 10-20 on separate lines\n");
            Console.ReadKey();
            i = 10;
            while (i < 21)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.Write("\n");
            Console.Write("Print 1-100 on separated lines\n");
            Console.ReadKey();
            for (i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("********");
            }
            Console.ReadKey();
        }
    }
}
