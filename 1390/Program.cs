using System;
using System.Collections.Generic;
using System.Linq;

namespace _1390
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());


            int result = SolveKSorting(arr, k);
            Console.WriteLine(result);
        }

        static int SolveKSorting(int[] arr, int k)
        {
            int n = arr.Length;
            var valuesWithIndices = new (int value, int index)[n];
            for (int i = 0; i < n; i++)
            {
                valuesWithIndices[i] = (arr[i], i);
            }


            Array.Sort(valuesWithIndices, (a, b) => a.value.CompareTo(b.value));


            var targetPositions = new int[n];
            for (int i = 0; i < n; i++)
            {
                targetPositions[valuesWithIndices[i].index] = i;
            }


            bool[] visited = new bool[n];
            int swapCount = 0;

            for (int i = 0; i < n; i++)
            {
                if (visited[i] || valuesWithIndices[i].index == i)
                {
                    visited[i] = true;
                    continue;
                }

                int cycleSize = 0;
                int j = i;

                while (!visited[j])
                {
                    visited[j] = true;
                    j = targetPositions[j];
                    cycleSize++;

                    if (Math.Abs(j - i) > k)
                    {
                        return -1;
                    }
                }

                if (cycleSize > 0)
                {
                    swapCount += cycleSize - 1;
                }
            }

            return swapCount;
        }
    }
}
