using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    class Program
    {
        static int Factor(int a)
        {
            int R = 1;
            for (int i = 1; i < a+1; i++)
            {
                R *= i;
            }
            return R;
        }

        static async Task<int> FactorAsync(int a)
        {
            Console.WriteLine(" FactorAsync начал работу");
            int result = await Task<int>.Run(() => Factor(a));
            Console.WriteLine(" FactorAsync окончил работу");
            return result;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("\tРабота с асинхронным программированием\n");

            Console.Write(" Введите целое число: ");
            int R = FactorAsync(int.Parse(Console.ReadLine())).Result;
            Console.WriteLine($"\tФакториал числа = {R}");
            Console.ReadKey();
        }
    }
}
