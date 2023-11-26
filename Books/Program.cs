using BookStore.Customers;

namespace BookStore.Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var booksManager = BooksManager.GetInstance();
            var bookFactory = new BookFactory();

            var fantasyBook = bookFactory.Create(BookGenre.Fantasy, "The Fantasy Book", "Max Mustermann", 123, 10);
            var romanceBook = bookFactory.Create(BookGenre.Romance, "The Romance Book", "Daniel Mustermann", 321, 10);
            var nonFictionBook =
                bookFactory.Create(BookGenre.NonFiction, "The NonFiction Book", "Stefan Mustermann", 55, 10);
            var badFantasyBook =
                bookFactory.Create(BookGenre.Fantasy, "The not good Fantasy Book", "Stefan Meier", 55, 10);

            booksManager.AddBook(fantasyBook);
            booksManager.AddBook(romanceBook);
            booksManager.AddBook(nonFictionBook);
            booksManager.AddBook(badFantasyBook);

            booksManager.UpdateStock(fantasyBook, -1);
            booksManager.UpdateStock(romanceBook, 1);
            booksManager.UpdateStock(nonFictionBook, -2);

            booksManager.RemoveBook(badFantasyBook);

            booksManager.PrintAll();
            
            //testing customer
            ICustomerFactory basicCustomerFactory = new BasicCustomerFactory();
            Customer basicCustomer = basicCustomerFactory.Create();
            basicCustomer.id = 0;
            basicCustomer.firstName = "Basic";
            basicCustomer.lastName = "Customer";
            basicCustomer.emailAddress = "basic.customer@xyz.com";
            basicCustomer.PrintCustomerInfo();
            
            ICustomerFactory childCustomerFactory = new ChildCustomerFactory();
            Customer childCustomer = childCustomerFactory.Create();
            childCustomer.id = 1;
            childCustomer.firstName = "Child";
            childCustomer.lastName = "Customer";
            childCustomer.emailAddress = "child.customer@xyz.com";
            ((ChildCustomer)childCustomer).MaximumBooksPerMonth = 5;
            childCustomer.PrintCustomerInfo();

            ICustomerFactory premiumCustomerFactory = new PremiumCustomerFactory();
            Customer premiumCustomer = premiumCustomerFactory.Create();
            premiumCustomer.id = 2;
            premiumCustomer.firstName = "Premium";
            premiumCustomer.lastName = "Customer";
            premiumCustomer.emailAddress = "premium.customer@xyz.com";
            ((PremiumCustomer)premiumCustomer).freeBooksPerMonth = 10;
            premiumCustomer.PrintCustomerInfo();

        }
    }
}