namespace BookStore.Books;

abstract class Factory
{
    public abstract IBook Create(BookGenre genre, string title, string author, int pages, int stock);
}

class BookFactory : Factory
{
    public override IBook Create(BookGenre genre, string title, string author, int pages, int stock)
    {
        return genre switch
        {
            BookGenre.Romance => new RomanceBook(title, author, pages, stock),
            BookGenre.Fantasy => new FantasyBook(title, author, pages, stock),
            BookGenre.NonFiction => new NonFictionBook(title, author, pages, stock),
            _ => throw new ArgumentOutOfRangeException(nameof(genre), genre, null)
        };
    }
}