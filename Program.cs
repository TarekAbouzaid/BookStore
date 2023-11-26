using BookStore.Customers;

namespace BookStore.Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var booksManager = BooksManager.GetInstance();
            var bookFactory = new BookFactory();

            var logger = new Logger();
            var timestampLogger = new TimestampLogger(logger);
            var bookStockLogger = new BookStockLogger(logger);

            var fantasyBook = bookFactory.Create(BookGenre.Fantasy, "The Fantasy Book", "Max Mustermann", 123, 10);
            var romanceBook = bookFactory.Create(BookGenre.Romance, "The Romance Book", "Daniel Mustermann", 321, 10);
            var nonFictionBook =
                bookFactory.Create(BookGenre.NonFiction, "The NonFiction Book", "Stefan Mustermann", 55, 10);
            var badFantasyBook =
                bookFactory.Create(BookGenre.Fantasy, "The not good Fantasy Book", "Stefan Meier", 55, 10);


            
            //testing customer
            var customerFactory = new CustomerFactory();
            var student1 = customerFactory.Create("Paul", "Mustermann", "paul.mustermann@gmail.com", CustomerType.Student);
            var vip1 = customerFactory.Create("Thomas", "Mustermann", "thomas.mustermann@gmail.com", CustomerType.VIP);





            booksManager.AddBook(romanceBook);
            booksManager.UpdateStock(romanceBook, 1);
            booksManager.AddBook(badFantasyBook);
            booksManager.UpdateStock(badFantasyBook, 1);
            booksManager.AddBook(nonFictionBook);
            booksManager.UpdateStock(nonFictionBook, 1);

            student1.BorrowBook(romanceBook);
            booksManager.UpdateStock(romanceBook, -1);
            timestampLogger.Log(romanceBook.Title);
            bookStockLogger.Log(romanceBook.Title);

            vip1.BorrowBook(badFantasyBook);
            booksManager.UpdateStock(badFantasyBook, -1);
            timestampLogger.Log(badFantasyBook.Title);
            bookStockLogger.Log(badFantasyBook.Title);

            student1.ShowBorrowedBooks();
            vip1.ShowBorrowedBooks();

            booksManager.PrintAll();


        }
    }
}