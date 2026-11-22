using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_P58.Intro
{
    /// <summary>
    /// Масиви, багатомірні масиви, цикли
    /// </summary>
    internal class Arrays
    {
        public void Run()
        {
            Console.WriteLine("Масиви, багатомірні масиви, цикли");
            // На відміну від С++, масиви є об'єктами, які "обслуговують"
            // послідовне однотипне сховище постійного розміру
            int[] arr1 = new int[10];   // базові 
            int[] arr2 = { 1, 2, 3 };   // форми
            int[] arr3 = [1, 2, 3];   // новий синтаксис (collection expression)
            foreach(int x in arr1)      // цикл ітератор - аналог for(int x : arr1)
            {
                Console.Write(x + " ");  // 0 0 .. 0 - значення за замовчанням (default)
            }
            Console.WriteLine();
            //                    наявність .Length додатково свідчить, що arr - це об'єкт
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();

            // Багатомірні масиви поділяються на дві групи:
            // 2D (multi-D) - "прямокутні" масиви, в яких по всіх вимірах однакові блоки
            //  ******
            //  ******
            //  ******
            // jagged - "рвані" масиви (масиви масивів), в яких по кожному виміру можуть
            //  бути різні довжини елементів
            //  *******
            //  ***
            //  ****
            int[,] arr2d1 = new int[3, 4] { 
                {1,2,3,4}, 
                {2,3,4,5}, 
                {3,4,5,6} 
            };
            int[,,] arr3d = // new int[3, 3, 2]
            {
                { {1,2}, {3,4}, {5,6} },
                { {2,3}, {3,4}, {5,6} },
                { {3,4}, {3,4}, {5,6} },
            };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr2d1[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("=====================");
            // jagged arrays
            int[][] jarr = new int[4][];
            jarr[0] = new int[2] { 1, 2 };
            jarr[1] = new int[4] { 1, 2, 3, 4 };
            jarr[2] = new int[3] { 1, 2, 3 };
            jarr[3] = new int[5] { 1, 2, 3, 4, 5 };
            foreach (int[] a in jarr)
            {
                foreach(int x in a)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }
            Random rnd1 = new Random();  // базовий синтаксис (повний)
            Random rnd2 = new();         // новий синтаксис - якщо зазначено тип, то в new можна не повторювати
            var rnd3 = new Random();     // автоматичне визначення типу (var)

            Console.WriteLine( rnd1.Next(0, 100) );
        }
    }
}
