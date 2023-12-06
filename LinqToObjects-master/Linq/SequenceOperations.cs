using System;
using System.Collections.Generic;
using System.Linq;
using Linq.DataSources;

namespace Linq
{
    /// <summary>
    /// Considers the use methods 'Concat', and 'Zip' for entire sequences in LINQ queries.
    /// </summary>
    public static class SequenceOperations
    {
        /// <summary>
        /// Creates one sequence that contains each array's values, one after the other.
        /// </summary>
        /// <returns>The sequence that contains each array's values, one after the other.</returns>
        public static IEnumerable<int> ConcatSeries()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            return numbersA.Concat(numbersB);
        }

        /// <summary>
        /// Creates one sequence that contains the names of all customers and products, including any duplicates.
        /// </summary>
        /// <returns>The sequence that contains the names of all customers and products, including any duplicates.</returns>
        public static IEnumerable<string> ConcatProjection()
        {
            List<Customer> customers = Customers.CustomerList;
            List<Product> products = Products.ProductList;

            var customerNames = from customer in customers
                                select customer.CompanyName;

            var productNames = from product in products
                               select product.ProductName;

            var allNames = customerNames.Concat(productNames);

            return allNames;

        }

        /// <summary>
        /// Calculates the dot product of two integer vectors.
        /// </summary>
        /// <returns>The dot product of two integer vectors.</returns>
        public static int DotProduct()
        {
            int[] vectorA = { 0, 2, 4, 5, 6 };
            int[] vectorB = { 1, 3, 5, 7, 8 };

            int dotProduct = vectorA.Zip(vectorB, (a, b) => a * b).Sum();

            return dotProduct;
        }
    }
}
