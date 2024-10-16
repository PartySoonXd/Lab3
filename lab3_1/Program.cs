using System;

namespace lab3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNum = random.Next(1, 11);

            Console.Write("Угадайте случайное число от 1 до 10: ");
            int userNum = 0;
            int counter = 0;

            while (randomNum != userNum)
            {
                userNum = Convert.ToInt32(Console.ReadLine());

                if (userNum > 10)
                {
                    Console.Write($"Нельзя писать число больше 10. Попробуйте еще раз: ");
                    continue;
                }

                counter++;

                if (userNum > randomNum)
                {
                    Console.Write($"Загаданное число меньше {userNum}. Попробуйте еще раз: ");
                }

                if (userNum < randomNum)
                {
                    Console.Write($"Загаданное число больше {userNum}. Попробуйте еще раз: ");
                }
            }

            Console.WriteLine($"Вы угадали число {randomNum} c {counter} раза");
            Console.ReadLine();
        }
    }
}
