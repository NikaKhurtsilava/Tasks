using System;

#pragma warning disable CA1062

namespace WorkingWithArrays
{
    public static class UsingRanges
    {
        public static int[] GetArrayWithAllElements(int[] array)
        {
            // TODO #3-1. Add the method implementation. The method should return a new array with all elements from "array" parameter.
            // See "Indices and ranges" documentation page: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
            return array[..];
        }

        public static int[] GetArrayWithoutFirstElement(int[] array)
        {
            // TODO #3-2. Add the method implementation. The method should return a new array with all elements from "array" parameter except the first one.
            return array[1..];
        }

        public static int[] GetArrayWithoutTwoFirstElements(int[] array)
        {
            // TODO #3-3. Add the method implementation. The method should return a new array with all elements from "array" parameter except the two first elements.
            return array[2..];
        }

        public static int[] GetArrayWithoutThreeFirstElements(int[] array)
        {
            // TODO #3-4. Add the method implementation. The method should return a new array with all elements from "array" parameter except the three first elements.
            return array[3..];
        }

        public static int[] GetArrayWithoutLastElement(int[] array)
        {
            // TODO #3-5. Add the method implementation. The method should return a new array with all elements from "array" parameter except the last element.
            return array[..^1];
        }

        public static int[] GetArrayWithoutTwoLastElements(int[] array)
        {
            // TODO #3-6. Add the method implementation. The method should return a new array with all elements from "array" parameter except the two last elements.
            return array[..^2];
        }

        public static int[] GetArrayWithoutThreeLastElements(int[] array)
        {
            // TODO #3-7. Add the method implementation. The method should return a new array with all elements from "array" parameter except the three last elements.
            return array[..^3];
        }

        public static bool[] GetArrayWithoutFirstAndLastElements(bool[] array)
        {
            // TODO #3-8. Add the method implementation. The method should return a new array with all elements from "array" parameter except the first element and the last elements.
            return array[1..^1];
        }

        public static bool[] GetArrayWithoutTwoFirstAndTwoLastElements(bool[] array)
        {
            // TODO #3-9. Add the method implementation. The method should return a new array with all elements from "array" parameter except the two first elements and the last two elements.
            return array[2..^2];
        }

        public static bool[] GetArrayWithoutThreeFirstAndThreeLastElements(bool[] array)
        {
            // TODO #3-10. Add the method implementation. The method should return a new array with all elements from "array" parameter except the three first elements and the three last elements.
            return array[3..^3];
        }
    }
}
