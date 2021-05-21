using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integerOperationsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;
            Console.WriteLine("a =  " + a + ", b = " + b);

            int result = a + b;
            Console.WriteLine("Сложение, a + b =  " + result);

            result = a * b;
            Console.WriteLine("Умножение, a * b =  " + result);

            result = a / b;
            Console.WriteLine("Деление, a / b =  " + result + " a и  b - целые числа, деление только нацело");

            int resultMod = a % b;
            Console.WriteLine("Деление с остатком, a % b =  " + resultMod + "Остаток от деления");

            Console.ReadKey();

            // При вычислении выражений, содержащих несколько операций, приоритет операций такой же как в математике.Чтобы повысить приоритет операции, используются скобки:
            // 2 + 2 * 2 = 6
            // (2 + 2) * 2 = 8
        }
    }
}