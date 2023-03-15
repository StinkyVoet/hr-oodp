public class Temperature
{
    private double _celsius;
    
    public double Celsius
    {
        get => _celsius;
        set
        {
            if (value < -273.15) return;
            _celsius = value;
        }
    }

    public double Kelvin
    {
        get => Celsius + 273.15;
        set => Celsius = value - 273.15;
    }
}