using System;

namespace ExceptionHandling
{
    public static class HandlingExceptions
    {
        public static bool CatchException(object obj)
        {
            // TODO #1. Add a try-catch construction here to catch all exceptions. The method should return true if an exception is thrown; otherwise false.
            try
            {
                
                ThrowException(obj);

                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }

        public static bool CatchArgumentNullException(object obj, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;

            // TODO #2. Add a try-catch construction here to catch "ArgumentNullException". The method should return true if an "ArgumentNullException" is thrown and set "exceptionMessage" parameter to an exception message; otherwise the method should return false.
            try
            {
                ThrowException(obj);

                return false;
            }
            catch (ArgumentNullException ex)
            {
                exceptionMessage = ex.Message;

                return true;
            }
        }

        public static bool CatchArgumentException(int i, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;

            // TODO #3. Add a try-catch construction here to catch "ArgumentException". The method should return true if an "ArgumentException" is thrown and set "exceptionMessage" parameter to an exception message; otherwise the method should return false.
            try
            {
                ThrowException(new object(), i);

                return false;
            }
            catch (ArgumentException ex)
            {
                exceptionMessage = ex.Message;

                return true;
            }
        }

        public static bool CatchArgumentOutOfRangeException(int j, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;

            // TODO #4. Add a try-catch construction here to catch "ArgumentOutOfRangeException". The method should return true if an "ArgumentOutOfRangeException" is thrown and set "exceptionMessage" parameter to an exception message; otherwise the method should return false.
            
            try
            {
                ThrowException(new object(), 1, j);

                return false;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                exceptionMessage = ex.Message;

                return true;
            }
        }

        public static bool CatchExceptions(object obj, int i, int j, bool throwException, out string exceptionMessage)
        {
            exceptionMessage = string.Empty;

            // TODO #5. Add a try-catch construction here to catch exceptions with these types:
            // * Exception
            // * ArgumentException
            // * ArgumentNullException
            // * ArgumentOutOfRangeException
            // The method should return true if an exception of any type is thrown and set "exceptionMessage" parameter to an exception message; otherwise the method should return false.
            try
            {
                ThrowException(obj, i, j, throwException);

                return false;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                exceptionMessage = ex.Message;
                return true;
            }
            catch (ArgumentNullException ex)
            {
                exceptionMessage = ex.Message;
                return true;
            }
            catch (ArgumentException ex)
            {
                exceptionMessage = ex.Message;
                return true;
            }
            catch (Exception ex)
            {
                exceptionMessage = ex.Message;
                return true;
            }
        }

        private static void ThrowException(object obj, int i = 1, int j = 1, bool throwException = false)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj), "obj is null.");
            }

            if (i == 0)
            {
                throw new ArgumentException("i parameter is invalid.", nameof(i));
            }

            if (j < 0 || j > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(j), "j is out of range.");
            }

            if (throwException)
            {
#pragma warning disable CA2201 // Do not raise reserved exception types
                throw new Exception("exception is thrown.");
#pragma warning restore CA2201 // Do not raise reserved exception types
            }
            
        }
    }
}
