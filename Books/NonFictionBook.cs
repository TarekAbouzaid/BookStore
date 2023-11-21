namespace BookStore.Books;

public class NonFictionBook : IBook
{
    public NonFictionBook(string title, string author, int pages, int stock)
    {
        Title = title;
        Author = author;
        Pages = pages;
        Genre = BookGenre.NonFiction;
        Stock = stock;
    }

    public string Title { get; }
    public string Author { get; }
    public int Pages { get; }
    public BookGenre Genre { get; }
    public int Stock { get; set; }
}