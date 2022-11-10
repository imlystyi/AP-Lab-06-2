/* Lab_06_2_Iterative.cs
 * Якубовський Владислав
 * Лабораторна робота № 6.2 
 * Опрацювання одновимірних масивів ітераційними та рекурсивними способами (ітераційний спосіб).
 * Варіант 24 */
using System;

namespace AP_Lab_06_2_Iterative
{
    public class Lab_06_2_Iterative
    {
        readonly static Random random = new Random();

        public static void ReverseSortArray(ref int[] array)
        {
            bool wasSwapped;

            for (int ii = 0; ii < array.Length; ii++)
            {
                wasSwapped = false;

                for (int jj = 0; jj < array.Length - 1; jj++)
                    if (array[jj] < array[jj + 1])
                    {
                        (array[jj], array[jj + 1]) = (array[jj + 1], array[jj]);

                        wasSwapped = true;
                    }

                if (!wasSwapped) return;
            }
        }

        static int[] GenerateArray(int size)
        {
            int[] generatedArray = new int[size];

            for (int ii = 0; ii < size; ii++)
                generatedArray[ii] = random.Next(-100, 100);

            return generatedArray;
        }

        static void DisplayArray(int[] array)
        {
            for (int ii = 0; ii < array.Length; ii++)
                Console.Write(((ii == 0) ? "{ " : "") + $"{array[ii]}" + ((ii < array.Length - 1) ? ", " : "") + ((ii == array.Length - 1) ? " }\n" : ""));
        }

        static void Main()
        {   
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.Write("Введіть розмір масиву: ");

            int n = int.Parse(Console.ReadLine());

            int[] a = GenerateArray(n);

            Console.Write("Згенерований масив: "); DisplayArray(a);

            ReverseSortArray(ref a);

            Console.Write("Сортований масив: "); DisplayArray(a);

            Console.Read();
        }
    }
}
