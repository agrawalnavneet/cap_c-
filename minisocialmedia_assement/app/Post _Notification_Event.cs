using System;
using System.Collections.Generic;


namespace MiniSocialMedia{
public partial class User
{
    private readonly List<Post> _posts = new();

    public event Action<Post>? OnNewPost;

    public void AddPost(string content)
    {
        if (string.IsNullOrWhiteSpace(content))
            throw new ArgumentException("Post content cannot be empty");

        if (content.Length > 280)
            throw new Exception("Post too long (max 280 characters)");

        string cleanedContent = content.Trim();

        Post post = new Post(this, cleanedContent);

        _posts.Add(post);

        OnNewPost?.Invoke(post);
    }

    public IReadOnlyList<Post> GetPosts()
    {
        return _posts.AsReadOnly();
    }}
}}

