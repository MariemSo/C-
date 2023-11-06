public class Ninja : Human
{
    public bool HasStealth ;
    public Ninja (string name, int str,int intel, int hp, bool hasStel = true) : base ( name, str, intel, 75, hp)
    {
        HasStealth = hasStel;
    }
    
    public override int Attack(Human target)
    {
        Random rand = new Random();
        int chance = 20;
        int roll = rand.Next(100);
        int dmg = Dexterity;
        int extradmg = 10;
        if (roll < chance)
        {
            dmg += extradmg;
        }
        target.Health -= dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    }

    public int Steal (Human target)
    {
                Health +=5;
        target.Health-=5;
        Console.WriteLine($"{Name} attacked {target.Name} and  his Heath is now {Health}");
        return Health;
    }
}