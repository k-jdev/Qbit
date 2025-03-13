using System;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace _1392
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var pairs = new (int value, int index)[n];
            for (int i = 0; i < n; i++)
            {
                pairs[i] = (arr[i], i);
            }

            Array.Sort(pairs, (a, b) => {
                bool isAOdd = Math.Abs(a.value) % 2 == 1;
                bool isBOdd = Math.Abs(b.value) % 2 == 1;


                if (isAOdd != isBOdd)
                    return isAOdd ? -1 : 1;


                return a.value.CompareTo(b.value);
            });

            Console.WriteLine(string.Join(" ", pairs.Select(p => p.value)));
        }
    }
}
