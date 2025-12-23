using System;

abstract class LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int ItemID { get; set; }

 
    public abstract void DisplayDetails();
    public abstract double CalculateLateFee(int days);
}
class Book : LibraryItem
{

    public override void DisplayDetails()
    {
        Console.WriteLine("Book Details:");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Item ID: {ItemID}");
    }
    public override double CalculateLateFee(int days)
    {
        return days * 1.0;
    }
}
class Magazine : LibraryItem
{
    public override void DisplayDetails()
    {
        Console.WriteLine("\nMagazine Details:");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Item ID: {ItemID}");
    }
    public override double CalculateLateFee(int days)
    {
        return days * 0.5;
    }
}

class Navn
{
   public  static void Navneet()
    {
        Book book = new Book
        {
            Title = "C# Basics",
            Author = "Navneet",
            ItemID = 101
        };
        Magazine magazine = new Magazine
        {
            Title = "Tech Monthly",
            Author = "Jupiter",
            ItemID = 202
        };
        book.DisplayDetails();
        Console.WriteLine("Late Fee for 3 days: " + book.CalculateLateFee(3));
        magazine.DisplayDetails();
        Console.WriteLine("Late Fee for 3 days: " + magazine.CalculateLateFee(3));
    }
}
