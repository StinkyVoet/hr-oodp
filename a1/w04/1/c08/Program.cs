using Newtonsoft.Json;

class Program
{
    public static void Main()
    {
        StreamReader reader = null!;
        List<Person> people = null!;

        try
        {
            reader = new StreamReader("People.json");
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"Missing JSON file. {e.Message}");
        }

        try
        {
            var file2Json = reader.ReadToEnd();
            people = JsonConvert.DeserializeObject<List<Person>>(file2Json)!;
        }
        catch (JsonReaderException e)
        {
            Console.WriteLine($"Invalid JSON. {e.Message}");
        }
        finally
        {
            reader.Close(); 
            reader.Dispose();
        }

        foreach (var car in people.SelectMany(person => person.OwnedCars))
        {
            for (int i = 0; i < 5; i++)
            {
                car.Drive();
            }
        }

        StreamWriter writer = null!;
        
        try
        {
            writer = new StreamWriter("People.json");
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"Missing JSON file. {e.Message}");
        }

        try
        {
            var list2Json = JsonConvert.SerializeObject(people);
            writer.Write(list2Json);
        }
        catch (JsonReaderException e)
        {
            Console.WriteLine($"Invalid JSON. {e.Message}");
        }
        finally
        {
            writer.Close();
            writer.Dispose();
        }
    }
}