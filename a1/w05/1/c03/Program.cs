class Program
{
    public static void Main()
    {
        Person john = new("John Doe");
        Student jane = new("Jane Doe");
        //Write your code here

        List<Person> people = new() {
            john,
            jane
        };

        foreach (var person in people)
        {
            Console.WriteLine(person.Introduce());
            if (person is Student student)
            {
                Console.WriteLine(student.Status());
            }
        }
    }
}