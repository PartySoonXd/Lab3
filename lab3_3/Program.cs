using System;

namespace lab3_3
{
    internal class Program
    {
        static int[] getRandomArray(int n)
        {
            Random random = new Random();   
            int[] array = new int[n];

            for (int i = 0; n > i; i++)
            {
                array[i] = random.Next(1, 21);
            }

            return array;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите количество студентов в группе: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] results = getRandomArray(n);

            int markThree = 0;
            int markFour = 0;
            int markFive = 0;

            foreach (var item in results)
            {
                switch (item)
                {
                    case 12: markThree++; break;
                    case 14: markFour++; break;
                    case 16: markFive++; break;
                }
            }

            Array.Sort(results);
            Console.WriteLine(
                $"Максимальное число подтягиваний {results[results.Length - 1]}, a минимальное - {results[0]}\n" +
                $"Оценку 3 получили - {markThree} человек\n" +
                $"Оценку 4 получили - {markFour} человек\n" +
                $"Оценку 5 получили - {markFive} человек"
            );

            Console.ReadLine();
        }
    }
}
