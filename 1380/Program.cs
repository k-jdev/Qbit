
using System;
namespace _1380
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] tokens = Console.ReadLine().Split();

            int[] count = new int[10];

            for (int i = 0; i < n; i++)
            {
                int digit = int.Parse(tokens[i]);
                count[digit]++;
            }

            string minNumber = BuildMinNumber(count);
            string maxNumber = BuildMaxNumber(count);

            Console.WriteLine(minNumber);
            Console.WriteLine(maxNumber);
        }

        static string BuildMinNumber(int[] count)
        {
            char[] result = new char[count[0] + count[1] + count[2] + count[3] + count[4] +
                                    count[5] + count[6] + count[7] + count[8] + count[9]];
            int index = 0;

            for (int i = 1; i < 10; i++)
            {
                if (count[i] > 0)
                {
                    result[index++] = (char)('0' + i);
                    count[i]--;
                    break;
                }
            }

            while (count[0]-- > 0)
            {
                result[index++] = '0';
            }

            for (int i = 1; i < 10; i++)
            {
                while (count[i]-- > 0)
                {
                    result[index++] = (char)('0' + i);
                }
            }

            return new string(result);
        }

        static string BuildMaxNumber(int[] count)
        {
            char[] result = new char[count[0] + count[1] + count[2] + count[3] + count[4] +
                                    count[5] + count[6] + count[7] + count[8] + count[9]];
            int index = 0;

            for (int i = 9; i >= 0; i--)
            {
                while (count[i]-- > 0)
                {
                    result[index++] = (char)('0' + i);
                }
            }

            return new string(result);
        }
    }

}
