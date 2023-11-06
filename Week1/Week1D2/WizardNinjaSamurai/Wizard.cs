public class Wizard : Human
{
    public Wizard (string name , int str, int dex) : base  (name , str,  25, dex,50)
    {

    }

    public override int Attack(Human target)
    {
        int dmg = Intelligence * 3;
        target.Health -=dmg;
        Health += dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage and his health is now {Health}!");
        return Health;
    }

    public int Heal ( Human target)
    {
        int heal = Intelligence*3;
        target.Health += heal;
        return target.Health;
    }
}