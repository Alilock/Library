using System;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library BookCentre = new Library();

            Book book1 = new Book()
            {
                Name = "The Kite Runner",
                Author = "Xalid Huseyni",
                Price = 8.99,
                Genre = "Roman"
            };
            Book book2 = new Book()
            {
                Name = "Siddhartha",
                Author = "Hermann Hesse",
                Price = 6.99,
                Genre = "Philosophical fiction"
            };
            Book book3 = new Book()
            {
                Name = "Martin Edden",
                Author = "Jack London",
                Price = 8.99,
                Genre = "Kunstlerroman"
            };
            Journal journal1 = new Journal()
            {
                Name = "Times",
                Company = "Southern Newspapers",
                Price = 18.50
            };
            Journal journal2 = new Journal()
            {
                Name = "Molla Nesreddin",
                Company = "Celil Memmedquluzade",
                Price = 0.12
            };
            BookCentre.AddProduct(book1);
            BookCentre.AddProduct(book2);
            BookCentre.AddProduct(book3);
            BookCentre.AddProduct(journal1);
            BookCentre.AddProduct(journal2);

            Console.WriteLine("1. Kitablarini sayini goster ");
            Console.WriteLine("2. Jurnallarin sayini goster ");
            Console.WriteLine("3. Kitablarin siyahisini goster ");
            Console.WriteLine("4. Jurnallarin siyahisini goster");
            string opt = Console.ReadLine();
            switch (opt)
            {
                case "1":
                    Console.WriteLine(BookCentre.GetBooksCount());
                    break;
                case "2":
                    Console.WriteLine(BookCentre.GetJournalsCount());
                    break;
                case "3":
                    foreach (var item in BookCentre.GetProducts(true))
                    {
                        item.GetInfo();
                    }
                    break;
                case "4":
                    foreach (var item in BookCentre.GetProducts(false))
                    {
                        item.GetInfo();
                    }
                    break;



                default:
                    Console.WriteLine("Duzgun secim edin ");
                    break;
            }



        }
    }
}
