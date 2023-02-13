var attack = 50;
var critChance = 0.33;
var bossHP = 1000;

Random r = new();

while (bossHP > 0)
{
    var damage = r.NextDouble() <= critChance ? attack*2 : attack;
    Console.WriteLine($"Boss HP: {bossHP}\nDamage: {damage}\n");
    bossHP -= damage;
}

Console.WriteLine("Boss defeated");