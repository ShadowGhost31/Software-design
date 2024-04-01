using System;

namespace AuthenticatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trying to create multiple instances of Authenticator
            Authenticator auth1 = Authenticator.Instance;
            Authenticator auth2 = Authenticator.Instance;

            // auth1 and auth2 should refer to the same instance
            Console.WriteLine(object.ReferenceEquals(auth1, auth2)); // Output: True
        }
    }
}
