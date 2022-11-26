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
        private static void Main(string[] args)
        {
            char[] alpha = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            var alphabet = new List<char>(alpha);
            var nums = new List<int>();

            int test = int.Parse(Console.ReadLine());
            nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();
            var word = new List<string>();
            int counter = 0;
            var sb = new StringBuilder();
            for (int i = 0; i < test; i++)
            {
                int chars = nums[0];
                int place = nums[1];

                for (int j = 0; j < chars; j++)
                {
                    sb.Append(alpha[j]);
                    counter++;
                }
            }
            Console.WriteLine(sb);
        }
    }
}