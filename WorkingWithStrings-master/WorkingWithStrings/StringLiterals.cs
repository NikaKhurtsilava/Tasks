using System;

// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo
// ReSharper disable IdentifierTypo
namespace WorkingWithStrings
{
    public static class StringLiterals
    {
        /// <summary>
        /// Returns a "abc" string.
        /// </summary>
        public static string ReturnAbcStringLiteral()
        {
            return "abc";
        }

        /// <summary>
        /// Returns a "ABCDEF" string.
        /// </summary>
        public static string ReturnAbcdefStringLiteral()
        {
            // TODO #1-1. Implement the method - return a string literal.
            return "ABCDEF";
        }

        /// <summary>
        /// Returns an empty string.
        /// </summary>
        public static string ReturnEmptyString()
        {
            // TODO #1-2. Implement the method - return an empty literal.
            // Use String.Empty static field: https://docs.microsoft.com/en-us/dotnet/api/system.string.empty
            return "";
        }

        /// <summary>
        /// Returns a file path.
        /// </summary>
        public static string ReturnFilePathStringLiteral()
        {
            // TODO #1-3. Implement the method - return "c:\documents\files\myfile0234.txt" string literal.
            return @"c:\documents\files\myfile0234.txt";
        }

        /// <summary>
        /// Returns a file path.
        /// </summary>
        public static string ReturnFilePathVerbatimStringLiteral()
        {
            // TODO #1-4. Implement the method - return "c:\documents\files\myfile0234.txt" verbatim string literal.
            // See @ article in C# Reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/verbatim
            return @"c:\documents\files\myfile0234.txt";
        }
    }
}
