using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 7, 4, 1, 5, 3};

            Console.WriteLine("Selection Sort");
            SelectionSort(array);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("*** *** *** ***");
            Console.WriteLine();

            array = new int[] { 2, 7, 4, 1, 5, 3};
            Console.WriteLine("Bubble Sort");
            BubbleSort(array);
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("*** *** *** ***");
            Console.WriteLine();

            Console.ReadLine();
        }

        static void SelectionSort(int[] array)
        {
            // O(n^2) - slow sorting algorithm

            for (int i = 0; i < array.Length - 1; i++)
            {
                int iMin = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[iMin])
                    {
                        iMin = j;
                    }
                }

                int temp = array[i];
                array[i] = array[iMin];
                array[iMin] = temp;
            }
        }

        static void BubbleSort(int[] array)
        {
            // Best case, when array is already sorted - O(n)
            // Worst case: O(n^2) - slow sorting algorithm

            for (int k = 1; k < array.Length; k++)
            {
                var flag = 0;
                for (int i = 0; i < array.Length - k; i++)
                {
                    if (array[i] > array[i+1])
                    {
                        int temp = array[i];
                        array[i] = array[i+1];
                        array[i+1] = temp;
                        flag = 1;
                    }
                }

                if (flag == 0)
                {
                    break;
                }
            }
        }
    }
}
