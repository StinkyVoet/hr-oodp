class Person
{
    public string Name;
    public Job? DayJob = null;

    public Person(string name, Job dayJob)
    {
        Name = name;
        DayJob = dayJob;
    }

    public string Info()
    {
        return DayJob != null ? $"{Name} works as a {DayJob.Name}" : $"{Name} is in between jobs";
    }
}