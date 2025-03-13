using System;
using System.Collections.Generic;

namespace _1382
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(" ");
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            int[] sortedUniqueNumbers = FindNumbers(arr);
            Console.WriteLine(sortedUniqueNumbers.Length);
            Console.WriteLine(string.Join(" ", sortedUniqueNumbers));
        }

        static int[] FindNumbers(int[] arr)
        {
            List<int> arrOfNumbers = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!arrOfNumbers.Contains(arr[i]))
                {
                    arrOfNumbers.Add(arr[i]);
                }
            }

            BubbleSort(arrOfNumbers);

            return arrOfNumbers.ToArray();
        }

        static void BubbleSort(List<int> list)
        {
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
    }
}
