using System;
using System.Collections.Generic;

namespace tuples
{
  class Program
  {
    static void Main(string[] args)
    {
      List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>()
            {
                ("screws", 5.25, 250),
                ("pipes", 9.78, 10)
            };
      transactions.Add(("Bandaids", 6, 250));

      (string product, int amount, int quantity) staples = ("Staples", 4, 50);
      transactions.Add("Staples", 4, 50);


      int TotalProductsSold = 0;
      double TotalRevenue = 0;

      foreach ((string product, double amount, int quantity) t in transactions)
      {
        // Logic goes here to look up quantity and amount in each transaction
        TotalProductsSold += t.quantity;
        TotalRevenue += t.quantity * t.amount;
      }

      Console.WriteLine($"We sold {TotalProductsSold} products for a total revenue of ${TotalRevenue}");
    }
  }
}
