using System;

namespace lab3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius = 4;
            int inputCounter = 0;
            int crossingCounter = 0;
            int numOfCircles = 12;

            while (inputCounter != numOfCircles)
            {
                Console.Clear();
                inputCounter++;

                Console.WriteLine($"--- {inputCounter}-ая окружность ---");
                Console.Write("Введите координату x: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите координату y: ");
                int y = Convert.ToInt32(Console.ReadLine());

                double range = Math.Sqrt(x * x + y * y);

                if (range <= radius * 2)
                {
                    crossingCounter++;
                }
            }
            Console.WriteLine($"{crossingCounter} из {inputCounter} пересекаются с заданной окружностью");
            Console.ReadLine();
        }
    }
}
