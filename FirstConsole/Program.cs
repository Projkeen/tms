using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyName
{
    class FirstName
    {
        static void Main(string[] args)
        {
            string name, surname;

            Console.WriteLine("Ваше имя:");

            name = Console.ReadLine();

            Console.WriteLine("Ваша фамилия:");

            surname = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Hello " + name + " " + surname + "!");

            Console.ReadLine();
        }
    }
}


