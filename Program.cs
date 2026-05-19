using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_
{
    internal class Program
    {
        //Method in C#
        /* A method is a block of code that performs a specific task.
         * It is defined within a class and can be called to execute the code it contains.*/

        //Example of a method in C#

        static void greet(int age) 
        { 
            Console.WriteLine("Hello, I am Denisa and I am " + age + " years old.");
        }

        static void Main(string[] args)
        {
            // this is a single line comment

            /* this is a multi line comment
               that spans multiple lines
               and ends here */

        int number = 42; // this is an integer variable

            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, I am Denisa and the Number : " + number);
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "! Welcome to C# programming.");

            /* Data types in C#:
                 - int: Represents a 32-bit integer. int a;
                 - float: Represents a single-precision floating-point number. float pi = 3.14f; 4 bytes
                 - long: Represents a 64-bit integer. long b; 8 bytes
                 - double: Represents a double-precision floating-point number. double c; 8 bytes
                 - string: Represents a sequence of characters. string d = 'Denisa'; 2 bytes per character
                 - bool: Represents a boolean value (true or false). bool isTrue = true; 1 bite
                 - char: Represents a single character. char e = 'A'; 2 bytes
             */

            int a = 5;
            float pi = 3.14f;
            bool isTrue = true;
            double c = 3.14159D;
            long d = 123456789L;
            string address = "Gandhinagar, Gujrat";
            char e = 'A';

            // example of using variables and data types

            Console.WriteLine("this is integer data - a = " + a);
            Console.WriteLine("this is float data - pi = " + pi);
            Console.WriteLine("this is double data - c = " + c);
            Console.WriteLine("this is long data - d = " + d);
            Console.WriteLine("this is string data - address = " + address);
            Console.WriteLine("this is char data - e = " + e);


            //typ casting in c#
            /* there are two types of type casting in C#:
             - Implicit Casting (automatically) - converting a smaller type to a larger type size
               char -> int -> long -> float -> double

             - Explicit Casting (manually) - converting a larger type to a smaller size type
               double -> float -> long -> int -> char
             */

            // Implicit Casting example

            float num1 = (int)10.50;
            Console.WriteLine("Implicit Casting: " + num1); // Output: 10

            // Explicit Casting example

            int num2 = 18;
            double num3 = 454523;
            float num4 = 'A';

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);

            //if else statement in c#

            /* if (condition)
             {
                 // code to execute if condition is true
             }
             else
             {
                 // code to execute if condition is false
             }
             */

            // Example of if-else statement

            int no = 15;
            if (no > 10)
            {
                Console.WriteLine("num2 - " + num2, "is greater than 10");
            }
            else
            {
                Console.WriteLine("num2 is not greater than 10");
            }

            // Loops in C#

            /* There are three types of loops in C#:
             - for loop: Executes a block of code a specified number of times.
             - while loop: Executes a block of code as long as a specified condition is true.
             - do-while loop: Executes a block of code at least once, and then continues to execute it as long as a specified condition is true.
             */

            // Example of for loop

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("for loop iteration: " + i);
            }

            // Example of do-while loop

            int n = 1;
            do
            {
                Console.WriteLine("do-while loop iteration: " + n);
                n++;
            } while (n < 7);

            // Example of while loop

            int y = 0;
            while (y < 3)
            {
                Console.WriteLine("while loop iteration: " + y);
                y++;
            }

            //break statement in c#

            /* The break statement is used to exit a loop or switch statement prematurely. When the break statement is 
             * encountered, the control is transferred to the statement immediately following the loop or switch block. */

            // Example of break statement

            for (int x = 1; x < 5; x++)
            {
                Console.WriteLine("X value is " + x);
                if (x >= 3)
                {
                    break;
                }
            }

            //continue statement in c#
            /* The continue statement is used to skip the current iteration of a loop and move to the next iteration. 
             * When the continue statement is encountered, the control is transferred to the beginning of the loop for the next iteration. */

            // Example of continue statement

            for (int z = 1; z <= 5; z++)
            {
                if (z == 3)
                {
                    continue; // Skip the rest of the loop body when x is 3
                }
                Console.WriteLine("Z value is " + z);
            }
            greet(21);


            // oop in c#

            Player p = new Player();
            p.Name = "Denisa";
            p.age = 21;
            Console.WriteLine("Player Name: " + p.Name);
            Console.WriteLine(p.age);
        }
    }
}
