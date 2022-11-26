using System;
using System.Linq;

namespace Рождена_дата
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] birthdayInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] currentYearInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var birthday = new DateTime(2022, birthdayInput[1], birthdayInput[0]);
            var currentDate = new DateTime(currentYearInput[2], currentYearInput[1], currentYearInput[0]);
            TimeSpan diff = birthday - currentDate;
            Console.WriteLine(diff.Days);
        }
    }
}