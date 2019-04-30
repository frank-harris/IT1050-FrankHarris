using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
  //QUESTION 2
             p[0] p[1] p[2] p[3]
 
  //QUESTION 3
            Console.Write("Question 3: Array of months:\n");
            string[] months = { "january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december" };
            for (int counter = 0; counter < 12; counter++)
            {
                Console.WriteLine("{0}  {1} \n", counter, months[counter]);
            }
           

    //QUESTION 4
            string[] seasons = { "Winter", "Spring", "Summer", "Fall" };
            foreach (string S in seasons)
            {
                Console.WriteLine("{0}, ", S);
            }
            

    //QUESTION 5
            int[] randomNumber = new int[1000];
            Random random = new Random();

            for (int index = 0; index < 1000; index++)
                randomNumber[index] = random.Next(0, 100);
            foreach (int R in randomNumber)
            {

                Console.Write("{0} ", R);

            }
 * 
 * 
 * 
 * 
 */

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Question 6");
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine(names[i]);
                i++;
            }

            Console.WriteLine("Press a key");
            Console.ReadKey();

            Console.WriteLine("\nQuestion 7");
            i = 0;
            while (i < names.Length)
            {
                Console.WriteLine("{0,2}. {1}", i, names[i]);
                i++;
            }
            Console.WriteLine("Press a key");
            Console.ReadKey();


            Console.WriteLine("\nQuestion 8");
            foreach (string N in names)
            {
                Console.WriteLine(N);
                
            }
            Console.WriteLine("Press a key");
            Console.ReadKey();


        }



    }
}
