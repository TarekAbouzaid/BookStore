using BookStore.Books;

namespace BookStore.Customers;

public abstract class Customer : ICustomer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public abstract List<IBook> BorrowedBooks { get; set; }
    public CustomerType CustomerType{ get; set; }

    public void BorrowBook(IBook book)
    {
        BorrowedBooks.Add(book);
    }

    public void ReturnBook(IBook book)
    {
        BorrowedBooks.Remove(book);
    }

    public abstract void ShowBorrowedBooks();
}