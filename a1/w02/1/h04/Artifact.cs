class Artifact
{
    public double Rarity, Condition;
    
    public Artifact(double Rarity, double Condition)
    {
        this.Rarity = Rarity;
        this.Condition = Condition;
    }

    public double GetValue() => Rarity * Condition;

    public string Appraise() => $"Value: {GetValue()}";

    public bool isEqualTo(Artifact artifact)
    {
        if (artifact == null) return false;
        return this.Rarity == artifact.Rarity && this.Condition == artifact.Condition;
    }
}