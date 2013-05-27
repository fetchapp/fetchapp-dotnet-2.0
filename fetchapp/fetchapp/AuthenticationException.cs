using System;

namespace FetchAppAPI
{
    public class AuthenticationException : Exception
    {

        public AuthenticationException(String message) : base(message)
        {
            
        }

    }
}
