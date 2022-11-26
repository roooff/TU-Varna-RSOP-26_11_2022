using System;
using System.Linq;

namespace Рождена_дата
{
    internal class Program
    {
        private static void Main(String[] args)
        {
            int[] birthdayInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] currentYearInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int year = 0;
            int start = currentYearInput[2];
            if (birthdayInput[1] == 2 && birthdayInput[0] == 29)
            {
                for (int i = start; i <= 3000; i++)
                {
                    if (i % 4 == 0 || i % 400 == 0 && i % 100 != 0)
                    {
                        year = i;
                        break;
                    }
                }
            }
            else
            {
                year = currentYearInput[2];
            }
            var birthday = new DateTime(year, birthdayInput[1], birthdayInput[0]);

            var currentDate = new DateTime(currentYearInput[2], currentYearInput[1], currentYearInput[0]);
            TimeSpan diff = birthday - currentDate;
            Console.WriteLine(diff.Days);
        }
    }
}