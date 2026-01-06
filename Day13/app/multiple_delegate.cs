using System;

//    multiple delegate
delegate void OrderDelegate(string orderId);

class NotificationService
{
    public static void SendEmail(string id)
    {
        Console.WriteLine("EMAIL SENT for " + id);
    }

    public static void SendSMS(string id)
    {
        Console.WriteLine("SMS SENT for " + id);
    }
}

class Main2
{
    public static void main2()
    {
        OrderDelegate notify = null;

        notify += NotificationService.SendEmail;
        notify += NotificationService.SendSMS;

        notify("order101");
    }
}
