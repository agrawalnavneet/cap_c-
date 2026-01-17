// using System;
// using System.Text;
// using System.Text.RegularExpressions;
// using System.Linq;

// public class Post
// {
//     public string Author { get; set; }
//     public string Content { get; set; }
//     public DateTime CreatedAt { get; set; }

//     public Post(string author, string content)
//     {
//         Author = author;
//         Content = content;
//         CreatedAt = DateTime.Now;
//     }

//     public override string ToString()
//     {
//         var sb = new StringBuilder();
//         sb.AppendLine($"{Author} | {CreatedAt}");
//         sb.AppendLine(Content);

//         var hashtags = Regex.Matches(Content, @"#[A-Za-z]+");

//         if (hashtags.Count > 0)
//         {
//             sb.Append("Tags: ");
//             sb.AppendJoin(", ", hashtags.Cast<Match>().Select(m => m.Value));
//         }

//         return sb.ToString().TrimEnd();
//     }
// }


// class Main1
// {
//     public static void main1()
//     {
//         Post post1 = new Post("Navneet", "I am learning C# today #CSharp #DotNet #Coding");
//         Post post2 = new Post("Rahul", "No tags in this post");

//         Console.WriteLine(post1);
//         Console.WriteLine();
//         Console.WriteLine(post2);
//     }
// }



using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text.Json.Serialization;

namespace MiniSocialMedia
{
    public class Post
    {
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        // Parameterless constructor required for JSON Deserialization
        public Post() { }

        public Post(User author, string content)
        {
            Author = author.Username;
            Content = content;
            CreatedAt = DateTime.Now;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{Author} | {CreatedAt}");
            sb.AppendLine(Content);

            var hashtags = Regex.Matches(Content, @"#[A-Za-z]+");

            if (hashtags.Count > 0)
            {
                sb.Append("Tags: ");
                sb.AppendJoin(", ", hashtags.Cast<Match>().Select(m => m.Value));
            }

            return sb.ToString().TrimEnd();
        }
    }
}