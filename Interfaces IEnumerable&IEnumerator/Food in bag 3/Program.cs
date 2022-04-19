using System;
using System.Collections;

namespace Food_in_bag_3
{
    class MyBag : IEnumerable, IEnumerator
    {
        string[] food = { "Cheese", "Milk", "Bread", "Whiskey", "Butter", "Meat", "Corn" }; // Массив из 7-ми элементов
        int position = -1;

        // Реализация интерфейса IEnumerable

        public IEnumerator GetEnumerator() // Возвращает перечислитель (IEnumerator), осуществляющий перебор коллекции
        {
            return this; // Возвращает сам себя
        }
        // Реализация интерфейса IEnumerator
        public bool MoveNext() // Перемещает перечислитель (IEnumerator) к следующему элементу в коллекции
        {
            if (position < food.Length - 1) // Если перечислитель < чем (длина массива-1) 
            {
                position++; // Возвращает true, если смогли переместить перечислитель (IEnumerator) к следующему элементу
                return true;
            }
            else
                return false; // Возвращает false, если не удалось переместить перечислитель (IEnumerator) (Достиг конца коллекции)

        }
        public void Reset()
        {
            position = -1; // Устанавливает перечислитель (IEnumerator) в его начальное значение
        }
        public object Current
        {
            get
            {
                return food[position]; // Возвращает текущий элемент в коллекции
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyBag bag = new MyBag();
            foreach (var food in bag) // Перебор каждого элемента в коллекции
                Console.WriteLine(food);
            Console.Read();
        }
    }

}

