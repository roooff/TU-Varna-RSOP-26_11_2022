using System;

namespace Комплекти
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //За всеки тест да се изведе единствено число, извеждащо броя на различните комплекти,
            //образувани чрез избор на P на брой подаръка (без повторения)
            //от всичките X видове подаръка и B на брой хартии (без повторения) от всичките Y видове хартии.

            uint tests = 0;
            uint quantityPerPurcahse; // Does not repeat
            uint giftwrappers;
            uint typesOfPurchases;// Does not repeat
            uint typesOfGiftWrappers;// Does not repeat
            for (int i = 0; i < tests; i++)
            {
                quantityPerPurcahse = uint.Parse(Console.ReadLine());
                giftwrappers = uint.Parse(Console.ReadLine());
                typesOfPurchases = uint.Parse(Console.ReadLine());
                typesOfGiftWrappers = uint.Parse(Console.ReadLine());

                uint sum = 0;
                sum += quantityPerPurcahse * typesOfPurchases * typesOfGiftWrappers * giftwrappers;
                quantityPerPurcahse++;
                typesOfPurchases++;
                typesOfGiftWrappers++;
                tests++;
            }
            Console.ReadKey();
        }
    }
}