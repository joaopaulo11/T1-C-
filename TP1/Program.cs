using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 45, 81, 29, 66, 03, 52, 51, 55, 74 };

            Console.WriteLine("Numeros gerados:");

            bubbleSort(numbers, numbers.Length);

            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);

            Console.ReadLine();
        }

        static void bubbleSort(int[] arr, int length)
        {
            int repos = 0;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - (i + 1); j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        repos = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = repos;
                    }
                }
            }
        }
    }
}
