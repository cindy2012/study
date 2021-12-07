using System;
using System.Collections.Generic;
using System.Linq;

namespace Try101LinqSamples
{
    public class JoinOperations
    {
        public List<Product> GetProductList() => Products.ProductList;
        public List<Customer> GetCustomerList() => Customers.CustomerList;

        public int CrossJoinQuery()
        {
            #region cross-join
            string[] categories = {
                "Beverages",
                //"Condiments",
                //"Vegetables",
                //"Dairy Products",
                //"Seafood"
            };

            List<Product> products = GetProductList();

            var q = from c in categories
                    join p in products on c equals p.Category
                    select (Category: c, p.ProductName);
            var qq = categories.Join(products, x => x, y => y.Category, (m, n) => new { Category = m, ProductName =n.ProductName});
            foreach (var v in q)
            {
                Console.WriteLine(v.ProductName + ": " + v.Category);
            }
            foreach (var v in qq)
            {
                Console.WriteLine(v.ProductName + ": " + v.Category);
            }
            #endregion
            return 0;
        }

        public int GroupJoinQquery()
        {
            #region group-join
            string[] categories = {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            List<Product> products = GetProductList();

            var q = from c in categories
                    join p in products on c equals p.Category into ps
                    select (Category: c, Products: ps);
            var qq = categories.GroupJoin(products, c => c, p => p.Category, (m, n) => new { Category = m, Products = n });
            foreach (var v in qq)
            {
                Console.WriteLine(v.Category + ":");
                foreach (var p in v.Products)
                {
                    Console.WriteLine("   " + p.ProductName);
                }
            }
            #endregion
            return 0;
        }

        public int CrossGroupJoin()
        {
            #region cross-group-join
            string[] categories = {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            List<Product> products = GetProductList();

            var q = from c in categories
                    join p in products on c equals p.Category into ps
                    from p in ps
                    select (Category: c, p.ProductName);
            var qq = categories
                .GroupJoin(products, c => c, p => p.Category, (m, n)
                => new { Category = m, Products = n}).SelectMany(a=> a.Products.Select(b=>new { Category=b.Category, ProductName=b.ProductName }));



            foreach (var v in q)
            {
                Console.WriteLine(v.ProductName + ": " + v.Category);
            }
            Console.WriteLine("------------");
            foreach (var v in qq)
            {
                Console.WriteLine(v.ProductName + ": " + v.Category);
               
            }
            #endregion
            return 0;
        }

        public int LeftOuterJoin()
        {
            #region left-outer-join
            string[] categories = {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            List<Product> products = GetProductList();

            var q = from c in categories
                    join p in products on c equals p.Category into ps
                    from p in ps.DefaultIfEmpty()
                    select (Category: c, ProductName: p == null ? "(No products)" : p.ProductName);

            foreach (var v in q)
            {
                Console.WriteLine($"{v.ProductName}: {v.Category}");
            }
            #endregion
            return 0;
        }
    }
}


