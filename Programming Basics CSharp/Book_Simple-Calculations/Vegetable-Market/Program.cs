using System;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegetables = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            double kgVegetables = double.Parse(Console.ReadLine());
            double kgFruits = double.Parse(Console.ReadLine());
            double amountBGN = kgFruits * priceFruits + kgVegetables * priceVegetables;
            double amountEUR = amountBGN / 1.94;
            Console.WriteLine(amountEUR);
        }
    }
}
