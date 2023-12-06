using System;
using System.Collections.Generic;
using System.Linq;
using Linq.DataSources;

namespace Linq
{
    /// <summary>
    /// Considers use join operations (methods 'Join', 'GroupJoin' and 'join' keyword) in LINQ queries.
    /// Join and GroupJoin definition:
    /// <see cref="IEnumerable{TOuter}"/>, <see cref="IEnumerable{TInner}"/> → <see cref="IEnumerable{TResult}"/>
    /// A join of two data sources is the association of objects in one data source with objects
    /// that share a common attribute in another data source.
    /// </summary>
    public static class JoinOperations
    {
        /// <summary>
        /// Joins two sequences based on Category and extracts pairs of values.
        /// </summary>
        /// <returns>Result of joining based on Category of elements of two sequences.</returns>
        public static IEnumerable<(string category, string productName)> JoinQuery()
        {
            string[] categories =
            {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };

            List<Product> products = Products.ProductList;

            var result = from category in categories
                         join product in products
                         on category equals product.Category into categoryProducts
                         from product in categoryProducts
                         select (category, product.ProductName);
            return result;
        }

        /// <summary>
        /// Gets all the products that match a given category. 
        /// </summary>
        /// <returns>All the products that match a given category bundled as a sequence.</returns>
        public static IEnumerable<(string category, IEnumerable<Product> productsName)> GroupJoinQuery()
        {
            string[] categories =
            {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",   
                "Seafood"
            };

            List<Product> products = Products.ProductList;

            var groupedProducts = from category in categories
                                  join product in products on category equals product.Category into matchingProducts
                                  select (category, products: matchingProducts);

            return groupedProducts;
        }

        /// <summary>
        /// Joins two sequences based on Category and extracts pairs of values.
        /// If the category has no products, it is included in the resulting sequence with the value "(No products)"
        /// Note how `Vegetables` shows up in the output even though it has no matching products.
        /// </summary>
        /// <returns>Result of joining of elements of two sequences.</returns>
        public static IEnumerable<(string category, string productName)> LeftOuterJoin()
        {
            string[] categories =
            {
                "Beverages",
                "Condiments",
                "Vegetables",
                "Dairy Products",
                "Seafood"
            };


            List<Product> products = Products.ProductList;

            var leftOuterJoinResult = from category in categories
                                      join product in products on category equals product.Category into categoryProducts
                                      from product in categoryProducts.DefaultIfEmpty(new Product { ProductName = "(No products)" })
                                      select (category, productName: product.ProductName);

            return leftOuterJoinResult;


        }
    }
}