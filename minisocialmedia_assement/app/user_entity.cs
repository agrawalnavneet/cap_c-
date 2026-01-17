// using System;
// using System.Collections.Generic;
// using System.Text.RegularExpressions;

// public interface IPostable { }

// public class InvalidEmailFormatException : Exception
// {
//     public InvalidEmailFormatException(string message) : base(message) { }
// }

// public partial class User : IPostable, IComparable<User>
// {
//     public string Username { get; init; }
//     public string Email { get; init; }

//     private readonly List<string> _posts = new();
//     private readonly HashSet<string> _following = new(StringComparer.OrdinalIgnoreCase);

//     public event Action<string>? OnNewPost;

//     public User(string username, string email)
//     {
//         if (string.IsNullOrWhiteSpace(username))
//             throw new ArgumentException("username");

//         string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
//         if (!Regex.IsMatch(email, pattern))
//             throw new InvalidEmailFormatException("Invalid email format");

//         Username = username.Trim();
//         Email = email.Trim().ToLower();
//     }

//     public int CompareTo(User? other)
//     {
//         if (other == null) return 1;
//         return string.Compare(Username, other.Username, StringComparison.OrdinalIgnoreCase);
//     }
// }

// class Main2
// {
//     public static void main2()
//     {
//         try
//         {
//             User user = new User(" Aman ", "Aman@Mail.COM");

//             Console.WriteLine("Username: " + user.Username);
//             Console.WriteLine("Email: " + user.Email);
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//     }
// }



using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text.Json.Serialization;

namespace MiniSocialMedia
{
    public class User : IPostable, IComparable<User>
    {
        public string Username { get; set; }
        public string Email { get; set; }

        // Changed to Public Property so JSON can save it
        public List<Post> Posts { get; set; } = new();

        // Events are skipped in JSON
        public event Action<Post>? OnNewPost;

        // Parameterless constructor for JSON
        public User() { }

        public User(string username, string email)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("username");

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, pattern))
                throw new InvalidEmailFormatException("Invalid email format");

            Username = username.Trim();
            Email = email.Trim().ToLower();
        }

        public void AddPost(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                throw new ArgumentException("Post content cannot be empty");

            if (content.Length > 280)
                throw new Exception("Post too long (max 280 characters)");

            string cleanedContent = content.Trim();

            // Pass 'this' user instance to the Post constructor
            Post post = new Post(this, cleanedContent);

            Posts.Add(post);
            OnNewPost?.Invoke(post);
        }

        public IReadOnlyList<Post> GetPosts()
        {
            return Posts.AsReadOnly();
        }

        public int CompareTo(User? other)
        {
            if (other == null) return 1;
            return string.Compare(Username, other.Username, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"@{Username}";
        }

        public string GetDisplayName()
        {
            return $"User: {Username} <{Email}>";
        }
    }
}