namespace BookStore.Books;

public class RomanceBook : IBook
{
    public RomanceBook(string title, string author, int pages, int stock)
    {
        Title = title;
        Author = author;
        Pages = pages;
        Genre = BookGenre.Romance;
        Stock = stock;
    }


    public string Title { get; }

    public string Author { get; }
    public int Pages { get; }
    public BookGenre Genre { get; }
    public int Stock { get; set; }
}