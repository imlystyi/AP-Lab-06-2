/* Lab_06_2_Recursive.cs
 * Якубовський Владислав
 * Лабораторна робота № 6.2 
 * Опрацювання одновимірних масивів ітераційними та рекурсивними способами (рекурсивний спосіб).
 * Варіант 24 */
using System;

namespace AP_Lab_06_2_Recursive
{
    public class Lab_06_2_Recursive
    {
        readonly static Random random = new Random();

        public static void ReverseSortArray(ref int[] array, int ii = 0, bool wasSwapped = false)
        {
            for (int jj = 0; jj < array.Length - 1; jj++)
                if (array[jj] < array[jj + 1])
                {
                    (array[jj], array[jj + 1]) = (array[jj + 1], array[jj]);

                    wasSwapped = true;
                }

            if (!wasSwapped) return;

            if (ii < array.Length - 1) 
                ReverseSortArray(ref array, ++ii);
        }

        static void GenerateArray(ref int[] array, int ii = 0)
        {
            if (ii < array.Length)
            {
                array[ii] = random.Next(-100, 100);

                GenerateArray(ref array, ++ii);
            }
        }

        static void DisplayArray(int[] array, int ii = 0)
        {
            if (ii < array.Length)
            {
                Console.Write(((ii == 0) ? "{ " : "") + $"{array[ii]}" + ((ii < array.Length - 1) ? ", " : "") + ((ii == array.Length - 1) ? " }\n" : ""));

                DisplayArray(array, ++ii);
            }
        }

        static void Main() 
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.Write("Введіть розмір масиву: ");

            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];

            GenerateArray(ref a);

            Console.Write("Згенерований масив: "); DisplayArray(a);

            ReverseSortArray(ref a);

            Console.Write("Сортований масив: "); DisplayArray(a);

            Console.Read();
        }
    }
}
