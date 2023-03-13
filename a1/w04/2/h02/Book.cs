public class Book
{
    public int ID;
    public string Title;

    public Book(int id, string? title = null)
    {
        ID = id;
        Title = title ?? "Title unknown";
    }

    public string Info() => $"ID = {ID}, Title = {Title}";
}