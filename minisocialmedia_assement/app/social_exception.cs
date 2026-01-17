using System;

namespace MiniSocialMedia
{
    public class InvalidEmailFormatException : Exception
    {
        public InvalidEmailFormatException(string message) : base(message) { }
    }

    public class SocialException : Exception
    {
        public SocialException(string message) : base(message) { }
        public SocialException(string message, Exception inner) : base(message, inner) { }
    }
}