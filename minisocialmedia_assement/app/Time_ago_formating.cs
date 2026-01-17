using System;

public static class SocialUtils
{
    public static string FormatTimeAgo(this DateTime pastTime)
    {
        TimeSpan diff = DateTime.UtcNow - pastTime;

        if (diff.TotalMinutes < 1)
        {
            return "just now";
        }
        else if (diff.TotalMinutes < 60)
        {
            return $"{(int)diff.TotalMinutes} min ago";
        }
        else if (diff.TotalHours < 24)
        {
            return $"{(int)diff.TotalHours} h ago";
        }
        else
        {
            return pastTime.ToString("MMM dd");
        }
    }
}
