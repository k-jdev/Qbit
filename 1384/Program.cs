using System;
namespace _1384
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int k = int.Parse(Console.ReadLine());

            BubbleSort(arr); 

            int minSum = 0;
            for (int i = 0; i < k; i++)
            {
                minSum += arr[i];
            }

            int maxSum = 0;
            for (int i = n - k; i < n; i++)
            {
                maxSum += arr[i];
            }

            Console.WriteLine($"{minSum} {maxSum}"); 
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
