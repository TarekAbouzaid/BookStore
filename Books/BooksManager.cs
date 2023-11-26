namespace BookStore.Books;

public sealed class BooksManager
{
    private static BooksManager _booksManager { get; set; }
    private List<IBook> Books { get; }

    private BooksManager()
    {
        Books = new List<IBook>();
    }

    public static BooksManager GetInstance()
    {
        if (_booksManager == null)
        {
            _booksManager = new BooksManager();
        }

        return _booksManager;
    }


    public void AddBook(IBook book)
    {
        Books.Add(book);
    }

    public void RemoveBook(IBook book)
    {
        Books.Remove(book);
    }

    public void Clear()
    {
        Books.Clear();
    }

    public void UpdateStock(IBook book, int value)
    {
        book.UpdateStock(value);
    }

    public void PrintAll()
    {
        foreach (var book in Books)
        {
            book.PrintInformation();
        }
    }

    public bool CheckAvailability(IBook book)
    {
        return Books.Contains(book);
    }
}