class Library
{
    public List<Book?> Books;
    public int MaxSize;

    public Library(int MaxSize)
    {
        this.MaxSize = MaxSize;
        Books = new List<Book?>(MaxSize);
    }

    public bool AddBook(int ID, string Title)
    {
        if (Books.Count >= MaxSize) return false;

        Books.Add(new Book(ID, Title));
        return true;
    }

    public Book? FindBook(int ID)
    {
        return Books.FirstOrDefault(b => b?.ID == ID);
    }

    public void ModifyBook(int ID, string Title)
    {
        if (FindBook(ID) == null) return;
        var index = Books.FindIndex(b => b?.ID == ID);
        Books[index] = new Book(ID, Title);
    }
}