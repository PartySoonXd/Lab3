using System;

namespace lab3_5
{
    internal class Program
    {
        static int[] addItemToArray(ref int[] myArray, int item)
        {
            int[] newArray = new int[myArray.Length + 1];

            for (int i = 0; i < myArray.Length; i++)
            {
                newArray[i] = myArray[i];
            }

            newArray[myArray.Length] = item;
            return newArray;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 0 для остановки");
            Console.Write("Введите число, которое хотите добавить в массив: ");
            int currentNum = Convert.ToInt32(Console.ReadLine());

            int[] myArray = { currentNum };

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Введите 0 для остановки");
                Console.WriteLine($"Текущий массив: [{string.Join(", ", myArray)}]");
                Console.Write("Введите число, которое хотите добавить в массив: ");

                currentNum = Convert.ToInt32(Console.ReadLine());

                if (currentNum == 0)
                {
                    break;
                }
                myArray = addItemToArray(ref myArray, currentNum);
            }

            int maxValue = 0;
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                if (myArray[i] > myArray[i + 1] && maxValue < myArray[i])
                {
                    maxValue = myArray[i];
                } else if (myArray[i] < myArray[i + 1] && maxValue < myArray[i + 1])
                {
                    maxValue = myArray[i + 1];
                }
            }

            Console.WriteLine($"Максимальное число в массиве - {maxValue}");
            myArray = addItemToArray(ref myArray, maxValue);
            Console.WriteLine($"Финальный массив: [{string.Join(", ", myArray)}]");
            Console.ReadLine();
        }
    }
}
