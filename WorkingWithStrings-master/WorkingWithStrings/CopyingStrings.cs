using System;
using System.Diagnostics;

namespace WorkingWithStrings
{
    public static class CopyingStrings
    {
        /// <summary>
        /// Copies one character from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyOneChar(string source, string destination)
        {
            char[] destinationArray = destination.ToCharArray();

            source.CopyTo(0, destinationArray, 4, source.Length);

            return new string(destinationArray);
        }

        /// <summary>
        /// Copies three characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyThreeChars(string source, string destination)
        {
            // TODO #8-1. Analyze unit tests for the method, and add the method implementation.
            // Use String.CopyTo method to copy characters: https://docs.microsoft.com/en-us/dotnet/api/system.string.copyto
            char[] destinationArray = destination.ToCharArray();

            source.CopyTo(0, destinationArray, 0, 3);

            return new string(destinationArray);
        }

        /// <summary>
        /// Copies five characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopyFiveChars(string source, string destination)
        {
            // TODO #8-2. Analyze unit tests for the method, and add the method implementation.
            char[] destinationArray = destination.ToCharArray();

            source.CopyTo(0, destinationArray, 4, 5);

            return new string(destinationArray);
        }

        /// <summary>
        /// Copies six characters from the <paramref name="source"/> to the <paramref name="destination"/>.
        /// </summary>
        public static string CopySixChars(string source, string destination)
        {
            // TODO #8-3. Analyze unit tests for the method, and add the method implementation.
            char[] destinationArray = destination.ToCharArray();

            source.CopyTo(2, destinationArray, 5, 6);

            return new string(destinationArray);
        }

        /// <summary>
        /// Gets a production code by copying substrings of the <paramref name="regionCode"/>, <paramref name="locationCode"/>, <paramref name="dateCode"/> and <paramref name="factoryCode"/> parameters to the <paramref name="template"/>.
        /// </summary>
        public static string GetProductionCode(string template, string regionCode, string locationCode, string dateCode, string factoryCode)
        {
            // TODO #8-4. Analyze unit tests for the method, and add the method implementation.
            char[] templateArray = template.ToCharArray();

            string substring1 = regionCode.Substring(1, 1);
            string substring2 = locationCode.Substring(4, 2);
            string substring3 = dateCode.Substring(3, 3);
            string substring4 = factoryCode.Substring(2, 4);

            substring1.CopyTo(0, templateArray, 0, substring1.Length);
            substring2.CopyTo(0, templateArray, 3, substring2.Length);
            substring3.CopyTo(0, templateArray, 7, substring3.Length);
            substring4.CopyTo(0, templateArray, 12, substring4.Length);
            return new string(templateArray);
        }
    }
}
