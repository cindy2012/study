using System;
using System.Collections.Generic;
using System.Linq;

namespace Try101LinqSamples
{
    public class AggregateOperators
    {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;

        public int CountSyntax()
        {
            #region count-syntax
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };

            int uniqueFactors = factorsOf300.Distinct().Count();

            Console.WriteLine($"There are {uniqueFactors} unique factors of 300.");
            #endregion
            return 0;
        }
        public int CountConditional()
        {
            #region count-conditional
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            int oddNumbers = numbers.Count(n => n % 2 == 1);

            Console.WriteLine("There are {0} odd numbers in the list.", oddNumbers);
            #endregion
            return 0;
        }
        public int NestedCount()
        {
            List<Customer> customers = GetCustomerList();
            var oderCounts = from c in customers
                             select (c.CustomerID, OrderCount: c.Orders.Count());
            foreach (var item in oderCounts)
            {
                Console.WriteLine($"ID:{item.CustomerID},OrderCount:{item.OrderCount}");
            }
            return 0;
        }
        public int GroupedCount()
        {
            List<Product> products = GetProductList();
            var result = from c in products
                         group c by c.Category into g
                         //select g;
                         select new { Category= g.Key, Count= g.Count() };
            foreach (var item in result)
            {
                Console.WriteLine($"Key:{item.Category}");
                Console.WriteLine($"Category:{item.Category},{item.Count}");
                //foreach (var c in item)
                //{
                //    Console.WriteLine($"Detail:{c.ProductID},{c.ProductName}");
                //}
            }
            return 0;
        }

        public int SumProjection()
        {
            #region sum-of-projection
            string[] words = { "cherry", "apple", "blueberry" };

            double totalChars = words.Sum(w => w.Length);

            Console.WriteLine($"There are a total of {totalChars} characters in these words.");
            #endregion
            return 0;
        }
        public int SumGrouped()
        {
            #region grouped-sum
            List<Product> products = GetProductList();

            var categories = from p in products
                             where p.Category == "Beverages"
                             group p by p.Category into g
                             select (Category: g.Key, TotalUnitsInStock: g.Sum(p => p.UnitsInStock));

            foreach (var pair in categories)
            {
                Console.WriteLine($"Category: {pair.Category}, Units in stock: {pair.TotalUnitsInStock}");
            }
            #endregion
            return 0;
        }

        public int MinGrouped()
        {
            #region min-grouped
            List<Product> products = GetProductList();

            var categories = from p in products
                             where p.Category == "Beverages"
                             group p by p.Category into g
                             select (Category: g.Key, CheapestPrice: g.Min(p => p.UnitPrice));

            foreach (var c in categories)
            {
                Console.WriteLine($"Category: {c.Category}, Lowest price: {c.CheapestPrice}");
            }
            #endregion
            return 0;
        }
        public int MinEachGroup()
        {
            #region min-each-group
            List<Product> products = GetProductList();

            var categories = from p in products
                             group p by p.Category into g
                             let minPrice = g.Min(p => p.UnitPrice)
                             select (Category: g.Key, CheapestProducts: g.Where(p => p.UnitPrice == minPrice));

            foreach (var c in categories)
            {
                Console.WriteLine($"Category: {c.Category}");
                foreach (var p in c.CheapestProducts)
                {
                    Console.WriteLine($"\tProduct: {p}");
                }
            }
            #endregion
            return 0;
        }
        public int AverageProjection()
        {
            #region average-projection
            string[] words = { "cherry", "apple", "blueberry" };

            double averageLength = words.Average(w => w.Length);

            Console.WriteLine($"The average word length is {averageLength} characters.");
            #endregion
            return 0;
        }

        public int AggregateSyntax()
        {
            #region aggregate-syntax
            int[] doubles = { 2, 3, 1, 4, 5 };

            int product = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);

            Console.WriteLine($"Total product of all numbers: {product}");
            #endregion
            return 0;
        }
        public int SeededAggregate()
        {
            #region aggregate-seeded
            double startBalance = 100.0;

            int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };

            double endBalance =
                attemptedWithdrawals.Aggregate(startBalance,
                    (balance, nextWithdrawal) =>
                        ((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance));

            Console.WriteLine($"Ending balance: {endBalance}");
            #endregion
            return 0;
        }
    }
}