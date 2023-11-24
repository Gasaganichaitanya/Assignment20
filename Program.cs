using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpAssignment
{

    public class Program
    {
        public static int Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return (number * Factorial(number - 1));
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1 ");
            Console.WriteLine("Hello , World!");
            Console.WriteLine("\n");
            
            Console.WriteLine("Task 2: Variable and user input");
            string Name;
            Console.WriteLine("Enter a name");
            Name = Console.ReadLine();
            Console.WriteLine("Hello ,"+Name +"!" );
            Console.WriteLine("\n");
            
            Console.WriteLine("Task 3 : Basic Arithmetic");
            double num1, num2;
            Console.WriteLine("Enter a number1 ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number2 ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum: {num1 + num2}");
            Console.WriteLine($"Difference: {num1 - num2}");
            Console.WriteLine($"Product: {num1 * num2}");

            if (num2 != 0)
            {
                Console.WriteLine($"Division: {num1 / (double)num2}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!");
            }

            Console.WriteLine($"Modulus: {num1 % num2}");
            Console.WriteLine("\n");
            
            Console.WriteLine("Task 4: Control Structures");
            double num;
            Console.WriteLine("Enter a numner to find weather it is Even or Odd ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("{0} is a Even Number", num);
            }
            else
            {
                Console.WriteLine("{0} is Odd Number", num);
            }
            Console.WriteLine("\n");
            
            Console.WriteLine("Task 5 : Loops");
            Console.WriteLine("Choose by which you want loop to print 1 to 10 numbers on Console \n1.For \n2.While");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    for (int i = 1; i < 11; i++)
                    {
                        Console.Write(i + " ");
                    }
                    break;
                case 2:
                    int x = 0;
                    while (x < 11)
                    {
                        Console.Write(x + " ");
                        x++;
                    }
                    break;
                default:
                    Console.WriteLine("You choose invalid Operation");
                    break;

            }
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Task 6 : Arrays");
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Total Elements in the array is ");
            Console.Write("{");
            foreach (int i in array)
            {
                Console.Write(i + ", ");
            }
            Console.Write("}");
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            Console.WriteLine("\nSum of the total elements in the array is : " + sum);
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Task 7: Methods");
            Console.WriteLine("Enter a number to Finds Factorial");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Factorial of {m} is {Factorial(m)}");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("Task 8: Exception Handling");
            Console.WriteLine("\nTask 8: Exception Handling");
            int age;

            while (true)
            {
                Console.Write("Enter your age: ");

                if (int.TryParse(Console.ReadLine(), out age))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            if (age < 18)
                Console.WriteLine("You are a minor.");
            else if (age >= 18 && age <= 65)
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are a senior.");

            Console.ReadKey();
        }
    }
}