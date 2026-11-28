using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_P58.Types
{
    internal class Pract1
    {
        public void Start()
        {
            StartTask1();
        }
        private void StartTask2()
        {
            Console.Write("Task 2: Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
        }
        private bool IsFibonacci(int num)
        {
            // 1 1  Fn = Fn-1 + Fn-2
            // 1 1 2 3 5 8 13 ...
            long a = 1, b = 1;
            do
            {
                if (b == num) return true;
                (a, b) = (b, a + b);
            } while (b < num);
            return false;
        }

        private void StartTask1()
        {
            Console.Write("Task 1: Enter range from: ");
            int rangeFrom = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter range to: ");
            int rangeTo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Product: {Task1(rangeFrom, rangeTo)}");
        }

        private long Task1(int rangeFrom, int rangeTo)
        {
            long res = 1;
            for(int i = Math.Min(rangeFrom, rangeTo); i <= Math.Max(rangeFrom, rangeTo); ++i)
            {
                res *= i;
            }
            return res;
        }
    }
}
/* Практика:
 * https://materials.itstep.org/content/9a240e51-9a0a-44e6-83d8-6664b292f0d4/uk
 */