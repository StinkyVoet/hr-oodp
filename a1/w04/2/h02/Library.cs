public class Library
{
    public readonly List<Book> Books;

    public Library(List<Book>? books = null)
    {
        Books = books ?? new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void AddBook(int id, string title)
    {
        AddBook(new Book(id, title));
    }

    public Book? FindBook(int id) => Books.Find((b) => b.ID == id);
    public Book? FindBook(string idString)
    {
        if (int.TryParse(idString, out var id)) return Books.Find((b) => b.ID == id);
        Console.WriteLine($"ID = {idString}: not a valid book ID. Input string was not in a correct format.");
        return null;
    }
}