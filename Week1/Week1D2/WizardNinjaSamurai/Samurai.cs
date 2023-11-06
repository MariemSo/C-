public class Samurai : Human
{
    public Samurai (string name , int str, int intel, int dex) : base ( name , str, intel, dex,200)
    {
    
    }

    public override int Attack(Human target)
    {
        target.Health = base.Attack(target);

        if (target.Health<50)
        {
            target.Health = 0;
        }
        System.Console.WriteLine(target.Health);
        return target.Health;
    }

    public int Meditate ()
    {
        Health = 200;
        Console.WriteLine(Health);
        return Health;
    }
}