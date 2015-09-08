using System;

namespace Verifier.Exceptions
{
    public class UserInterfaceException:System.Exception
    {
        public UserInterfaceException(String message) : base(message)
        {
        }

        public UserInterfaceException(Int32 code, String message) : base("خطای " + code + ": " + message)
        {
        }

        public UserInterfaceException(Int32 code, String message, Exception ex)
            : base("خطای " + code + ": " + message, ex)
        {
        }
    }
}