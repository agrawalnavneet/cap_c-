using System;
using ItemAlias = LibrarySystem.Items;

namespace LibrarySystem{
    namespace Items
    {
        class Book{
            public void Show()
            {
                Console.WriteLine("This is a Book");
            }
        }
        class Magazine{
            public void Show()
            {
                Console.WriteLine("This is a Magazine");}}}
    namespace Users
    {
        class Member{
            public void Show(){
                Console.WriteLine("This is a Library Member");}}}
    class Na{
       public  static void Nam()
        {
            ItemAlias.Book book = new ItemAlias.Book();
            ItemAlias.Magazine magazine = new ItemAlias.Magazine();

            book.Show();
            magazine.Show();
        }
    }
}
