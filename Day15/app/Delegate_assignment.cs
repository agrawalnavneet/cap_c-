using System;
using System.Collections.Generic;
namespace EcommerceAssessment
{
    public class Repository<T>
    {
       private List<T> items = new List<T>();
       public void Add(T item)
        {
           items.Add(item);
        }
        public List<T> GetAll()
        {
            return items;
        }
    }
    public class Order
    {
        public int OrderId{get;set;}
        public string CustomerName{get;set;}
        public double Amount{get;set;}
        public override string ToString()
        {
            return $"Orderid: {OrderId},Customer: {CustomerName},Amount: {Amount}";
        }
    }
    public delegate void OrderCallback(string message);
    public class OrderProcessor
    {
        public event Action<string> OrderProcessed;
        public void ProcessOrder(Order order,Func<double,double> taxCalculator,Func<double, double> discountCalculator,Predicate<Order> validator,OrderCallback callback)
        {
            if(!validator(order))
            {
                callback("order validation failed");
            }
        double tax = taxCalculator(order.Amount);
        double discount = discountCalculator(order.Amount);
        order.Amount = order.Amount + tax - discount;
        callback($"Order {order.OrderId} processed successfully.");
        OrderProcessed?.Invoke($"Event: Oder {order.OrderId} completed");
        }
    }
}