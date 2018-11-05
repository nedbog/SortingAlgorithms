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

            Console.ReadLine();
        }

        static void SelectionSort(int[] array)
        {
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
    }
}
