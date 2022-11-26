using System;
using System.Collections.Generic;

namespace Decryption
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            string s = Console.ReadLine().ToUpper();
            int n = int.Parse(Console.ReadLine());
            string last = "";
            List<int> ints = new List<int>();

            if (n < 0)
            {
                return;
            }

            for (int i = n; i < s.Length; i++)
            {
                last += s[i];
            }

            s = s.Remove(n, last.Length);
            s = s.Insert(0, last);

            for (int i = 0; i < s.Length; i++)
            {
                ints.Add(s[i] + n);
            }

            ints.ForEach(x => Console.Write((char)x));
        }
    }
}