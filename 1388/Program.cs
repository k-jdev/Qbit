using System;
namespace _1388
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] coins = ReadCoins(n);
            BubbleSortDescending(coins);
            Console.WriteLine(SelectMinimumCoins(coins));
        }

        static int[] ReadCoins(int n)
        {
            string[] input = Console.ReadLine().Split();
            int[] coins = new int[n];
            for (int i = 0; i < n; i++)
                coins[i] = int.Parse(input[i]);
            return coins;
        }

        static void BubbleSortDescending(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        static int SelectMinimumCoins(int[] coins)
        {
            int halfSum = 0, currentSum = 0, count = 0;
            foreach (int coin in coins)
                halfSum += coin;
            halfSum /= 2;

            foreach (int coin in coins)
            {
                currentSum += coin;
                count++;
                if (currentSum > halfSum)
                    break;
            }

            return currentSum;
        }
    }
}
