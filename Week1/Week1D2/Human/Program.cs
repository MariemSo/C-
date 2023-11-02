Human alex = new Human ("Alex");
Console.WriteLine(alex.Strength);
Human sam = new Human("Sam",5,10,8,200);
sam.Attack(alex);
alex.Attack(sam);