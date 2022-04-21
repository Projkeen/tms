using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {

                Console.WriteLine("Введите количество продуктов: ");
                var n = int.Parse(Console.ReadLine());
                var Product = new Product[n];

                for (int i = 0; i < n; i++)
                {
                    Product[i] = new Product();

                    Console.WriteLine("Ввод данных\n");

                    Console.WriteLine("Введите название:");

                    Product[i].title = Console.ReadLine();

                    Console.WriteLine("Введите вес / объем:");

                    Product[i].amount = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите примечание(Цвет, форма):");

                    Product[i].notice = Console.ReadLine();


                    Console.WriteLine(Product[i].ToString());
                }
                Console.WriteLine("\nПовторить ввод?  y/n");
                char input = char.Parse(Console.ReadLine());
                if (input == 'n')
                {
                    exit = true;
                }

                // Console.ReadKey();
            }
        }
    }
    public class Product
    {
        public string title;
        public double amount;
        public string notice;

        public override string ToString()
        {
            return ($"Продукт: {title}, Количество: {amount} кг, заметки: {notice}");
        }
    }
}
