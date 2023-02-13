class Program
{
    private List<string> _tasks = new List<string>();
    
    static void Main()
    {
        var program = new Program();
        program.ListTasks();
        program._tasks.AddRange(new List<string>
        {
            "Mow lawn",
            "Pay taxes",
        });
        program.ListTasks();
        program._tasks.Remove("Mow lawn");
        program._tasks.Add("Shopping");
        program.ListTasks();
    }

    private void ListTasks()
    {
        Console.WriteLine($"Amount of tasks: {_tasks.Count}");
        foreach (var task in _tasks)
        {
            Console.WriteLine(task);
        }
    }
}