namespace BookStore.Books;

public class FantasyBook : IBook
{
    public FantasyBook(string title, string author, int pages, int stock)
    {
        Title = title;
        Author = author;
        Pages = pages;
        Genre = BookGenre.Fantasy;
        Stock = stock;
    }

    public string Title { get; }
    public string Author { get; }
    public int Pages { get; }
    public BookGenre Genre { get; }
    public int Stock { get; set; }
}