using System;
using System.Collections.Generic;
using System.Linq;

namespace StockPurchaseDIctionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("APL", "Apple");
            stocks.Add("CXW", "CoreCivic");
            stocks.Add("SBUX", "Starbucks");

            // the below should return "General Motors"
            var GM = stocks["GM"];

            // Create a list of ValueTuples that represents stock purchase.  Properties will be ticker, shares, price.
            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GE", shares: 150, price: 23.21));
            purchases.Add((ticker: "GE", shares: 32, price: 17.87));
            purchases.Add((ticker: "GE", shares: 80, price: 19.02));

            purchases.Add((ticker: "CAT", shares: 29, price: 23.11));
            purchases.Add((ticker: "CAT", shares: 29, price: 12.15));

            purchases.Add((ticker: "APL", shares: 87, price: 9.81));
            purchases.Add((ticker: "APL", shares: 6, price: 30.12));
            purchases.Add((ticker: "APL", shares: 67, price: 23.16));

            purchases.Add((ticker: "CXW", shares: 25, price: 46.12));
            purchases.Add((ticker: "CXW", shares: 54, price: 10.20));
            purchases.Add((ticker: "CXW", shares: 3, price: 5.71));

            purchases.Add((ticker: "SBUX", shares: 3, price: 25.14));
            purchases.Add((ticker: "SBUX", shares: 544, price: 29.51));

            //Create a total ownership report that computes the total value of each stock that you have purchased.
            //This is the basic relational database join algorithm between two tables.
            foreach (var (ticker, shares, price) in purchases)
            {
                if (ticker == "GE")
                {
                    var totalValue = shares * price;
                    Console.WriteLine($"{ticker}:  {totalValue}");
                }
                if (ticker == "CAT")
                {
                    var totalValue = shares * price;
                    Console.WriteLine($"{ticker}:  {totalValue}");
                }
                if (ticker == "APL")
                {
                    var totalValue = shares * price;
                    Console.WriteLine($"{ticker}:  {totalValue}");
                }
                if (ticker == "CXW")
                {
                    var totalValue = shares * price;
                    Console.WriteLine($"{ticker}:  {totalValue}");
                }
                if (ticker == "SBUX")
                {
                    var totalValue = shares * price;
                    Console.WriteLine($"{ticker}:  {totalValue}");
                }
            }

            foreach (var purchase in purchases)
            {
                var totalForPurchase = purchase.shares * purchase.price;

            }

            /*
             * Define a new Dictionary to hold the aggregated purchase information. - The key should be a string that is the full company name.
             * The value will be the valuation of each stock (price*amount) { "General Electric": 35900, "AAPL": 8445, ... }
            */

            Dictionary<string, int> purchaseValuations = new Dictionary<string, int>();

            


            // Iterate over the purchases and update the valuation for each stock
            //foreach ((string ticker, int shares, double price) purchase in purchases)
            //{
            // Does the company name key already exist in the report dictionary?
            // If it does, update the total valuation
            // If not, add the new key and set its value
            //}

            Console.ReadLine();
        }
    }
}
