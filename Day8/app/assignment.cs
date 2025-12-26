using System;
using System.Text;

class Assign
{
    public static string CleanseAndInvert(string ar)
    {
        // Check null or length less than 6
        if (string.IsNullOrEmpty(ar) || ar.Length < 6)
            return "";

        // Check for space, digit, or special character
        foreach (char c in ar)
        {
            if (!char.IsLetter(c))
                return "";
        }

        // Convert to lowercase
        ar = ar.ToLower();

        // Remove characters with even Ascii values
        StringBuilder sb = new StringBuilder();
        foreach (char c in ar)
        {
            if (((int)c) % 2 != 0)
            {
                sb.Append(c);
            }
        }

        // Reversing the string
        char[] arr = sb.ToString().ToCharArray();
        Array.Reverse(arr);

        // Convert even index characters to uppercase
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
            {
                arr[i] = char.ToUpper(arr[i]);
            }
        }

        return new string(arr);
    }

    public static void assign()
    {
        Console.WriteLine("Enter the word");
        string ar = Console.ReadLine();

        string result = CleanseAndInvert(ar);

        if (result == "")
        {
            Console.WriteLine("Invalid Input");
        }
        else
        {
            Console.WriteLine("The generated key is - " + result);
        }
    }
}
