using System;

namespace lab3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 0 для остановки");
            Console.Write("Введите число, которое хотите добавить в массив: ");
            int currentNum = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[1];
            while (currentNum != 0)
            {
                array[array.Length - 1] = currentNum;
                currentNum = Convert.ToInt32(Console.ReadLine());
            }

            string str = string.Join(" ", array);
            Console.WriteLine(str);
        }
    }
}
