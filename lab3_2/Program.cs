using System;
using System.Linq;

namespace lab3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите любое число больше 10: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n <= 10)
                {
                    throw new Exception("АШЫПКА! ЧИСЛО НЕ БОЛЬШЕ 10!");
                }

                int[] array = new int[n];
                int sumOfElems = 0;
                int powSumOfElems = 0;

                for (int i = 0; i < n; i++) {
                    array[i] = i + 1;
                }

                foreach (var item in array)
                {
                    sumOfElems += item;
                    powSumOfElems += item * item;

                    if (powSumOfElems > 500)
                    {
                        break;
                    }
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
