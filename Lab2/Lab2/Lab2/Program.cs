using System;
/* The program starts executing at the Main function.
 * 
 * There are two differences between an integer and double, decimals and size. 
 * An integer does not have any decimals and uses 4 bytes of memory while a double can have decimal places and
 * can represent a significantly larger value with its 8 bytes of memory.
 * 
 * A method used is calling "SetName" and assigning the passed string to the users name.
 * 
 * A Class can use "get" and "set" methods to read and write its variables.
 * 
 * A class is a template that contains data and/or functions.
 * An object is an actual "instance" of that class template. 
 * We can instantiate an unlimited number of a class and each instance
 * can have its own data different from other objects
 */

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
        int input1;
        int input2;
        int result;
        Console.Write("Multiply 2 numbers and display the result. \nEnter the first number: ");
            input1 = Convert.ToInt32( Console.ReadLine());
            Console.Write("Enter the second number: ");
            input2 = Convert.ToInt32( Console.ReadLine());
            result = input1 * input2;
            Console.WriteLine("The result is " + result.ToString());
            Console.WriteLine("Hello World! \nFrom Frank Harris");
            Console.WriteLine("Hello World!\tFrom Frank Harris");
            Console.ReadKey();
        }
    }
}
