using Newtonsoft.Json;

static class Calculator
{
    public static double Add(double a, double b) => a + b;

    public static double Subtract(double a, double b) => a - b;

    public static double Multiply(double a, double b) => a * b;

    public static double Divide(double a, double b) => a / b;

    public static double Modulo(double a, double b) => a % b;

    public static void StoreInMemory(double a)
    {
        StreamWriter writer = new StreamWriter("Memory.json");
        writer.Write(JsonConvert.SerializeObject(a));
        writer.Close();
        writer.Dispose();
    }

    public static double RestoreFromMemory()
    {
        StreamReader reader = new("Memory.json");
        var jsonString = reader.ReadToEnd();
        reader.Close();
        reader.Dispose();
        return JsonConvert.DeserializeObject<double>(jsonString)!;
    }
}