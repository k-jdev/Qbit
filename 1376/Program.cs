namespace _1376
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }
            SortNumbers(arr);
            Console.WriteLine(string.Join(" ", arr));
        }

        static void SortNumbers(int[] arr)
        {
            int evenCount = 0;
            int oddCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }

            int[] arrOfEvenNums = new int[evenCount];
            int[] arrOfOddNums = new int[oddCount];
            int evenIndex = 0;
            int oddIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arrOfEvenNums[evenIndex++] = arr[i];
                }
                else
                {
                    arrOfOddNums[oddIndex++] = arr[i];
                }
            }

            for (int i = 0; i < arrOfEvenNums.Length - 1; i++)
            {
                for (int j = i + 1; j < arrOfEvenNums.Length; j++)
                {
                    if (arrOfEvenNums[i] > arrOfEvenNums[j])
                    {
                        int temp = arrOfEvenNums[i];
                        arrOfEvenNums[i] = arrOfEvenNums[j];
                        arrOfEvenNums[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arrOfOddNums.Length - 1; i++)
            {
                for (int j = i + 1; j < arrOfOddNums.Length; j++)
                {
                    if (arrOfOddNums[i] > arrOfOddNums[j])  
                    {
                        int temp = arrOfOddNums[i];
                        arrOfOddNums[i] = arrOfOddNums[j];
                        arrOfOddNums[j] = temp;
                    }
                }
            }

            evenIndex = 0;
            oddIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr[i] = arrOfEvenNums[evenIndex++];
                }
                else
                {
                    arr[i] = arrOfOddNums[oddIndex++];
                }
            }
        }
    }
}
