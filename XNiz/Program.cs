using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace XNiz
{
    internal class Program
    {
        //char[] alpha = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
        //    'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        //int test = int.Parse(Console.ReadLine());
        //var alphabet = new List<char>(alpha);
        //var nums = new List<int>();
        //nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
        //.Select(int.Parse).ToList();

        //var sb = new StringBuilder();
        //string str = sb.ToString();
        //for (int i = 0; i < test; i++)
        //{
        //    int chars = nums[0];
        //    int place = nums[1];

        //    for (int j = 0; j < chars; j++)
        //    {
        //        sb.Append(alpha[j]);
        //    }

        // C# program to print all

        private class GFG
        {
            /**
            * permutation function
            * @param str string to
            calculate permutation for
            * @param l starting index
            * @param r end index
            */
            private string str = string.Empty;

            private static void permute(string str, int l, int r)
            {
                List<string> list = new List<string>();
                if (l == r)
                    list.Add(str);
                else
                {
                    for (int i = l; i <= r; i++)
                    {
                        str = swap(str, l, i);
                        permute(str, l + 1, r);
                        str = swap(str, l, i);
                    }
                }
            }

            /**
            * Swap Characters at position
            * @param a string value
            * @param i position 1
            * @param j position 2
            * @return swapped string
            */

            public static String swap(String a, int i, int j)
            {
                char temp;
                char[] charArray = a.ToCharArray();
                temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
                string s = new string(charArray);
                return s;
            }

            // Driver Code
            public static void Main()
            {
                String str = "ABC";
                int n = str.Length;
                permute(str, 0, n - 1);
            }
        }

        // This code is contributed by mits
    }
}