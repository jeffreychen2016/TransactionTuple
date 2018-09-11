using System;
using System.Collections.Generic;

namespace TransactionTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            var transactions = new List<(string, double, int)>();

            transactions.Add(("product-1", 10.00, 1));
            transactions.Add(("product-2", 11.00, 2));
            transactions.Add(("product-3", 12.00, 3));
            transactions.Add(("product-4", 13.00, 4));
            transactions.Add(("product-5", 14.00, 5));
            transactions.Add(("product-6", 15.00, 6));

            int itemSoldToday = 0;
            double totalRevenue = 0.00;

            foreach ((string product, double amount, int quantity) t in transactions)
            {
                // Logic goes here to look up quantity and amount in each transaction
                itemSoldToday += t.Item3;
                totalRevenue += t.Item2 * t.Item3;

            }

            Console.WriteLine("itemSoldToday: " + itemSoldToday);
            Console.WriteLine("totalRevenue: " + totalRevenue);
        }
    }
}
