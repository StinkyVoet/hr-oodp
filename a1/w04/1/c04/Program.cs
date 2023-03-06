using Newtonsoft.Json;

class Program
{
    public static void Main()
    {
        StreamReader reader = new("Cars.json");
        var file2Json = reader.ReadToEnd();
        var cars = JsonConvert.DeserializeObject<List<Car>>(file2Json)!;
        reader.Close();
        reader.Dispose();

        foreach (var car in cars)
        {
            for (int i = 0; i < 5; i++)
            {
                car.Drive();
            }
        }
        
        StreamWriter writer = new("Cars.json");
        var list2Json = JsonConvert.SerializeObject(cars);
        writer.Write(list2Json);
        writer.Close();
        writer.Dispose();
    }
}