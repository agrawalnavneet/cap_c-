using System;
using System.Collections.Generic;

public class Bike
{
    public string Model { get; set; }
    public string Brand { get; set; }
    public int PricePerDay { get; set; }
}

public class BikeUtility
{
   
    public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();


    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        int key = bikeDetails.Count + 1;
        bikeDetails.Add(key, new Bike
        {
            Model = model,
            Brand = brand,
            PricePerDay = pricePerDay
        });
    }

  
    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> groupedBikes =
            new SortedDictionary<string, List<Bike>>();

        foreach (var bike in bikeDetails.Values)
        {
            if (!groupedBikes.ContainsKey(bike.Brand))
            {
                groupedBikes[bike.Brand] = new List<Bike>();
            }
            groupedBikes[bike.Brand].Add(bike);
        }

        return groupedBikes;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        BikeUtility utility = new BikeUtility();

        while (true)
        {
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter the model");
                string model = Console.ReadLine();

                Console.WriteLine("Enter the brand");
                string brand = Console.ReadLine();

                Console.WriteLine("Enter the price per day");
                int price = int.Parse(Console.ReadLine());

                utility.AddBikeDetails(model, brand, price);
                Console.WriteLine("Bike details added successfully");
            }
            else if (choice == 2)
            {
                var grouped = utility.GroupBikesByBrand();

                foreach (var brand in grouped)
                {
                    Console.WriteLine(brand.Key);
                    foreach (var bike in brand.Value)
                    {
                        Console.WriteLine(bike.Model);
                    }
                    Console.WriteLine();
                }
            }
            else if (choice == 3)
            {
                break;
            }
        }
    }
}
