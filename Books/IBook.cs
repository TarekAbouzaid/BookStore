namespace BookStore.Books;

public interface IBook
{
    public string Title { get; }
    public string Author { get; }
    public int Pages { get; }
    public BookGenre Genre { get; }
    public int Stock { get; set; }

    public void UpdateStock(int value)
    {
        Stock += value;
    }

    public void PrintInformation()
    {
        Console.WriteLine(
            $"Title: {Title} written by {Author}\n Pages: {Pages}\n Genre: {Genre}\n Stock: {Stock}");
    }
}