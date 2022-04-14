using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double a, b;
                char operation;

                try
                {
                    Console.WriteLine("Введите первое число");
                    a = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введите число!");
                    continue;
                }

                Console.WriteLine("Укажите операцию");
                operation = Convert.ToChar(Console.ReadLine());
                switch (operation)
                {

                    case '+':
                        break;

                    case '-':
                        break;

                    case '*':
                        break;

                    case '/':
                        break;

                    default:
                        Console.WriteLine("Unknown operation!");
                        continue;

                }

                try
                {
                    Console.WriteLine("Введите второе число");
                    b = Convert.ToDouble(Console.ReadLine());
                }

                catch (Exception)
                {
                    Console.WriteLine("Введите число!");
                    continue;
                }



                if (operation == '+')
                {
                    Console.WriteLine("Результат = " + (a + b));
                }
                else if (operation == '-')
                {
                    Console.WriteLine("Результат = " + (a - b));
                }
                else if (operation == '*')
                {
                    Console.WriteLine("Результат = " + (a * b));
                }
                else if (operation == '/')
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Делить на 0 нельзя!");
                    }
                    else
                    {
                        Console.WriteLine("Результат = " + (a / b));
                    }
                }

                Console.ReadLine();

            }
        }
    }
}
