using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Collections.Generic;

namespace MiniSocialMedia
{
    class Program
    {
        private static readonly Repository<User> _users = new();
        private static User? _currentUser;
        private static readonly string _dataFile = "socialdata.json";

        static void Main()
        {
            Console.Title = "MiniSocial";
            LoadData();

            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("=== MiniSocial ===");

                    if (_currentUser == null)
                        ShowLoginMenu();
                    else
                        ShowMainMenu();
                }
                catch (Exception ex)
                {
                    ConsoleColorWrite($"Unexpected error: {ex.Message}", ConsoleColor.Red);
                    LogError(ex);
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        static void ShowLoginMenu()
        {
            Console.WriteLine("\n1. Register\n2. Login\n3. Exit");
            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1": Register(); break;
                case "2": Login(); break;
                case "3": SaveData(); Environment.Exit(0); break;
                default: Console.WriteLine("Invalid choice"); break;
            }
        }

        static void Register()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine()!;

            Console.Write("Email: ");
            string email = Console.ReadLine()!;

            if (_users.Find(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)) != null)
            {
                Console.WriteLine("User already exists");
                return;
            }

            try 
            {
                User user = new User(username, email);
                _users.Add(user);
                Console.WriteLine("Registration successful!");
                SaveData(); // Save immediately so data isn't lost
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating user: {ex.Message}");
            }
        }

        static void Login()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine()!;

            var user = _users.Find(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                Console.WriteLine("User not found");
                return;
            }
            _currentUser = user;
            Console.WriteLine("Login successful");
        }

        static void ShowMainMenu()
        {
            Console.WriteLine($"\nLogged in as {_currentUser}");
            Console.WriteLine("1. Post\n2. My Posts\n3. Logout\n4. Exit");

            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1": PostMessage(); break;
                case "2": ShowPosts(_currentUser!.GetPosts()); break;
                case "3": _currentUser = null; break;
                case "4": SaveData(); Environment.Exit(0); break;
                default: Console.WriteLine("Invalid choice"); break;
            }
        }

        static void PostMessage()
        {
            Console.Write("Post: ");
            string content = Console.ReadLine()!;

            if (string.IsNullOrWhiteSpace(content))
                return;

            try 
            {
                _currentUser!.AddPost(content);
                Console.WriteLine("Post added!");
                SaveData();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        static void ShowPosts(System.Collections.Generic.IReadOnlyList<Post> posts)
        {
            if (!posts.Any())
            {
                Console.WriteLine("No posts");
                return;
            }

            foreach (var post in posts)
            {
                Console.WriteLine(post);
                Console.WriteLine($"({post.CreatedAt.FormatTimeAgo()})");
                Console.WriteLine("----------------------");
            }
        }

        static void SaveData()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                var json = JsonSerializer.Serialize(_users.GetAll(), options);
                File.WriteAllText(_dataFile, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to save data.");
                LogError(ex);
            }
        }

        static void LoadData()
        {
            try
            {
                if (!File.Exists(_dataFile)) return;
                
                string json = File.ReadAllText(_dataFile);
                if(string.IsNullOrWhiteSpace(json)) return;

                var loadedUsers = JsonSerializer.Deserialize<List<User>>(json);
                if(loadedUsers != null)
                {
                    _users.LoadRange(loadedUsers);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to load data.");
                LogError(ex);
            }
        }

        static void LogError(Exception ex)
        {
            try 
            {
                File.AppendAllText("error.log", $"{DateTime.Now}\n{ex}\n\n");
            } 
            catch { }
        }

        static void ConsoleColorWrite(string message, ConsoleColor color)
        {
            var old = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = old;
        }
    }
}