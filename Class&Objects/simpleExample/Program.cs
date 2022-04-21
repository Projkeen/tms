using System;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Fish = new Product();
            Fish.title = "salmon";
            Fish.weight = 1;
            Fish.GetInfo();

            Product Chips = new Product();
            Chips.title = "Pringles";
            Chips.taste = "Cheese";
            Chips.GetInfo();

            Product Whiskey = new Product();
            Whiskey.title = "Ballantine's";
            Whiskey.volume = 0.7;
            Whiskey.GetInfo();

            Console.ReadKey();

        }
    }
    public class Product
    {
        public string title;
        public int weight;
        public string taste ;
        public double volume;
        public void GetInfo()
        {
            Console.WriteLine($"продукт: {title}, вес: {weight} кг, вкус {taste}, объем {volume} ");
        }
    }
}
