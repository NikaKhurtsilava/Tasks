using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    /// <summary>
    /// Considers how to create sequences of integers (methods 'Empty', 'Range', and 'Repeat') in LINQ queries.
    /// Generation Methods: void → <see cref="IEnumerable{TResult}"/>
    /// Generation refers to creating a new sequence of values.
    /// </summary>
    public static class GenerationOperations
    {
        /// <summary>
        /// Creates an empty sequence of integral numbers.
        /// </summary>
        /// <returns>Empty sequence of integral numbers.</returns>
        public static IEnumerable<int> EmptySequence()
        {
            return Enumerable.Empty<int>();
        }

        /// <summary>
        /// Generates a sequence of integral numbers within a specified range with additional information about their parity-oddness.
        /// </summary>
        /// <returns> The sequence of integral numbers in the specified range with additional information about their parity-oddness.
        /// </returns>
        public static IEnumerable<(int number, string oddEven)> RangeOfIntegers()
        {
            int start = 100; 
            int end = 119;   

            var result = from number in Enumerable.Range(start, end - start + 1)
                         select (number, (number % 2 == 0) ? "even" : "odd");

            return result;
        }

        /// <summary>
        /// Generates a sequence that contains one repeated value.
        /// </summary>
        /// <returns>The sequence that contains one repeated value. </returns>
        public static IEnumerable<int> RepeatNumber()
        {
            int repeatedValue = 7; 
            int repeatCount = 10;   

    
            var result = Enumerable.Repeat(repeatedValue, repeatCount);

            return result;
        }
    }
}
