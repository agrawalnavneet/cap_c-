using System;
using System.Collections.Generic;
using EcommerceAssessment;
class Program
{
    static void Main()
    {
        Repository<Order> orderRepository = new Repository<Order>();

        orderRepository.Add(new Order { OrderId = 1, CustomerName = "Alice", Amount = 5000 });
        orderRepository.Add(new Order { OrderId = 2, CustomerName = "Bob", Amount = 2000 });
        orderRepository.Add(new Order { OrderId = 3, CustomerName = "Charlie", Amount = 8000 });

        Func<double, double> taxCalculator = amount => amount * 0.18;
        Func<double, double> discountCalculator = amount => amount * 0.05;
        Predicate<Order> validator = order => order.Amount >= 3000;

        OrderCallback callback = message =>
        {
            Console.WriteLine("Callback: " + message);
        };

        Action<string> logger = msg => Console.WriteLine("Logger: " + msg);
        Action<string> notifier = msg => Console.WriteLine("Notifier: " + msg);

        OrderProcessor processor = new OrderProcessor();
        processor.OrderProcessed += logger;
        processor.OrderProcessed += notifier;

        foreach (var order in orderRepository.GetAll())
        {
            processor.ProcessOrder(
                order,
                taxCalculator,
                discountCalculator,
                validator,
                callback
            );
            Console.WriteLine();
        }

        List<Order> orders = orderRepository.GetAll();
        orders.Sort((o1, o2) => o2.Amount.CompareTo(o1.Amount));

        Console.WriteLine("Sorted Orders (Descending Amount):");
        foreach (var order in orders)
        {
            Console.WriteLine(order);
        }
    }
}
