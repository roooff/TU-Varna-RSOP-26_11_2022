using System;
using System.Diagnostics;
using System.Linq;

namespace Complects
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //За всеки тест да се изведе единствено число, извеждащо броя на различните комплекти,
            //образувани чрез избор на P на брой подаръка (без повторения)
            //от всичките X видове подаръка и B на брой хартии (без повторения) от всичките Y видове хартии.

            int tests = int.Parse(Console.ReadLine());
            // Does not repeat
            int[] all = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int quantityPerPurcahse = all[0]; // Does not repeat
            int giftwrappers = all[1];
            int typesOfPurchases = all[2];// Does not repeat
            int typesOfGiftWrappers = all[3];// Does not repeat

            for (int i = 0; i < tests; i++)
            {
                int sum = 0;
                sum += quantityPerPurcahse * typesOfPurchases * typesOfGiftWrappers * giftwrappers;
                quantityPerPurcahse++;
                typesOfPurchases++;
                typesOfGiftWrappers++;
                tests++;
            }
        }
    }
}