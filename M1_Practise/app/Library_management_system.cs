using System;
using System.Collections.Generic;
using System.Linq;

#region Interfaces

public interface IBook
{
    int Id { get; }
    string Title { get; }
    string Author { get; }
    string Category { get; }
    decimal Price { get; }
}

public interface ILibrarySystem
{
    void AddBook(IBook book, int quantity);
    void RemoveBook(IBook book, int quantity);
    decimal CalculateTotal();
    List<(string Category, decimal TotalPrice)> CategoryTotalPrice();
    List<(string Title, int Quantity, decimal Price)> BooksInfo();
    List<(string Category, string Author, int Count)> CategoryAndAuthorWithCount();
}

#endregion

#region Models

public class Book : IBook
{
    public int Id { get; }
    public string Title { get; }
    public string Author { get; }
    public string Category { get; }
    public decimal Price { get; }

    public Book(int id, string title, string author, string category, decimal price)
    {
        Id = id;
        Title = title;
        Author = author;
        Category = category;
        Price = price;
    }

    public override bool Equals(object obj)
    {
        return obj is Book book && Id == book.Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

#endregion

#region Library System

public class LibrarySystem : ILibrarySystem
{
    private Dictionary<IBook, int> _books = new Dictionary<IBook, int>();

    public void AddBook(IBook book, int quantity)
    {
        if (_books.ContainsKey(book))
            _books[book] += quantity;
        else
            _books.Add(book, quantity);
    }

    public void RemoveBook(IBook book, int quantity)
    {
        if (!_books.ContainsKey(book)) return;

        _books[book] -= quantity;

        if (_books[book] <= 0)
            _books.Remove(book);
    }

    public decimal CalculateTotal()
    {
        return _books.Sum(b => b.Key.Price * b.Value);
    }

    public List<(string Category, decimal TotalPrice)> CategoryTotalPrice()
    {
        return _books
            .GroupBy(b => b.Key.Category)
            .Select(g => (
                g.Key,
                g.Sum(x => x.Key.Price * x.Value)
            ))
            .ToList();
    }

    public List<(string Title, int Quantity, decimal Price)> BooksInfo()
    {
        return _books
            .Select(b => (
                b.Key.Title,
                b.Value,
                b.Key.Price
            ))
            .ToList();
    }

    public List<(string Category, string Author, int Count)> CategoryAndAuthorWithCount()
    {
        return _books
            .GroupBy(b => new { b.Key.Category, b.Key.Author })
            .Select(g => (
                g.Key.Category,
                g.Key.Author,
                g.Sum(x => x.Value)
            ))
            .ToList();
    }
}

#endregion

#region Program

class Library_Management
{
    public static void library_management()
    {
        ILibrarySystem library = new LibrarySystem();

        IBook book1 = new Book(1, "PeterPan", "JamesMatthewBarrie", "KidsClassics", 193);
        IBook book2 = new Book(2, "TheWizardOfOz", "FrankBaum", "KidsClassics", 394);

        library.AddBook(book1, 11);
        library.AddBook(book2, 3);

        Console.WriteLine("Book Info:");
        foreach (var b in library.BooksInfo())
        {
            Console.WriteLine($"Book Name:{b.Title}, Quantity:{b.Quantity}, Price:{b.Price}");
        }

        foreach (var c in library.CategoryTotalPrice())
        {
            Console.WriteLine($"Category:{c.Category}, Total Price:{c.TotalPrice}");
        }

        Console.WriteLine("Category And Author With Count:");
        foreach (var ca in library.CategoryAndAuthorWithCount())
        {
            Console.WriteLine($"Category:{ca.Category}, Author:{ca.Author}, Count:{ca.Count}");
        }

        Console.WriteLine($"Total Price: {library.CalculateTotal()}");
    }
}

#endregion
