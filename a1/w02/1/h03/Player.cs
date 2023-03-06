public class Player
{
    public string Name;
    public int HealthPoints, Power;

    public Player(string Name, int Power)
    {
        this.Name = Name;
        this.Power = Power;
        HealthPoints = 100;
    }

    public bool IsAlive() => HealthPoints > 0;

    public void TakeDamage(int Damage)
    {
        HealthPoints -= Damage;
        if (HealthPoints < 0) HealthPoints = 0;
    }
}