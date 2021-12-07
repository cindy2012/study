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
    }
}