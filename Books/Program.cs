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
        }
    }
}