using System;

interface IReservable
{
    void ReserveItem();}
interface INotifiable
{
    void SendNotification(string message);
}
class Boo : IReservable, INotifiable
{
    public void ReserveItem()
    {
        Console.WriteLine("Reservation successful.");
    }

    public void SendNotification(string message)
    {
        Console.WriteLine("Notification message sent: " + message);
    }
}
class Multi
{
   public static void Multiples()
    {
        Boo book = new Boo();

        book.ReserveItem();
        book.SendNotification("Your book has been reserved.");
    }
}
