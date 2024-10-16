using System;

namespace lab3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[4];
            while (true)
            {
                Console.Write("Введите 4 значения для a, b, c, d через пробел: ");
                string lineOfValues = Console.ReadLine();
                string[] strValuesArr = lineOfValues.Split(' ');

                try
                {
                    values = Array.ConvertAll(strValuesArr, item => int.Parse(item));
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Ошибка ввода. Попробуйте снова!");
                    continue;
                }
                break;
            }

            double[] results = new double[10];

            for (int x = 1; x < 11; x++)
            {
                double y = values[0] * Math.Sqrt(values[1] * x + values[3]) - values[2] * x;
                results[x - 1] = y;
            }

            double sumOfPositiveElems = 0;
            double sumOfElems = 0;

            foreach (var item in results)
            {
                if (item > 0)
                {
                    sumOfPositiveElems += item;
                }
                sumOfElems += item;
            }

            Console.WriteLine(
                $"Сумма положительных значений равна {sumOfPositiveElems}.\n" +
                $"Среднее значение функции y равно {sumOfElems / results.Length}"
            );
        }
    }
}
