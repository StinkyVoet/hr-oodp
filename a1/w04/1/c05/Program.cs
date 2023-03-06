using Newtonsoft.Json;

class Program
{
    public static void Main()
    {
        StreamReader reader = new("People.json");
        var file2Json = reader.ReadToEnd();
        var people = JsonConvert.DeserializeObject<List<Person>>(file2Json)!;
        reader.Close();
        reader.Dispose();

        foreach (var car in people.SelectMany(person => person.OwnedCars))
        {
            for (int i = 0; i < 5; i++)
            {
                car.Drive();
            }
        }
        
        StreamWriter writer = new("People.json");
        var list2Json = JsonConvert.SerializeObject(people);
        writer.Write(list2Json);
        writer.Close();
        writer.Dispose();
    }
}