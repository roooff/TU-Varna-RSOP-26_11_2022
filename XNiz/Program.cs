using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Numerics;

namespace XNiz
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char[] alpha = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            var alphabet = new List<char>(alpha);

            int test = int.Parse(Console.ReadLine());
            var word = new List<string>();
            int counter = 0;
            for (int i = 0; i < test; i++)
            {
                int chars = int.Parse(Console.ReadLine());
                int place = int.Parse(Console.ReadLine());

                for (int j = 0; i <= chars; j++)
                {
                    word.Add(word[j]);
                    counter++;
                }
            }
        }

        private static void Permute(List<string> word)
        {
        }
    }
}