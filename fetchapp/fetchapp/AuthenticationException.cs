using System;

namespace FetchAppAPI
{
    class AuthenticationException : Exception
    {

        public AuthenticationException(String message) : base(message)
        {
            
        }

    }
}
