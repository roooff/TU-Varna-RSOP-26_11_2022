using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace XNiz
{
    internal class GFG
    {
        private string str = string.Empty;

        private static void permute(string str, int l, int r, List<string> list)
        {
            if (l == r)
            {
                list.Add(str);
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r, list);
                    str = swap(str, l, i);
                }
            }
        }

        private static String swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }

        private static void Main()
        {
            int test = int.Parse(Console.ReadLine());
            for (int e = 0; e < test; e++)
            {
                char[] alpha = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();

                var sb = new StringBuilder();

                int chars = num[0];
                int place = num[1] - 1;

                for (int j = 0; j < chars; j++)
                {
                    sb.Append(alpha[j]);
                }

                List<string> list = new List<string>();
                string str = sb.ToString();
                int n = str.Length;
                permute(str, 0, n - 1, list);

                list.Sort();

                Console.WriteLine(list[place]);
            }
        }
    }
}