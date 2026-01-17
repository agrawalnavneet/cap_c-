using System;

namespce 
public partial class User :IPostable, IComparable<User>
{
    public string Username { get; init; }
    public string Email { get; init; }

    public int CompareTo(User other)
    {
        if (other == null)
            return 1;

        return string.Compare(
            this.Username,
            other.Username,
            StringComparison.OrdinalIgnoreCase
        );
    }

    public override string ToString()
    {
        return $"@{Username}";
    }
}

public partial class User
{
    public string GetDisplayName()
    {
        return $"User: {Username} <{Email}>";
    }
}
