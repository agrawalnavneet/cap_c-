using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace MiniSocialMedia
{ 
    
    public class User
    {
        public string Name { get; init; }

        public User(string name)
        {
            Name = name;
        }
    }
    
    
    public class Post
    {
        public User Author { get; init; }
        public string Content { get; init; }
        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;

        public Post(User author, string content)
        {
            Author = author;
            Content = content;
        }

        public override string ToString()
        {

        }
    }

}
