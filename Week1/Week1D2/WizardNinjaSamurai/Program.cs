Wizard gandalf = new Wizard("Gandalf", 50, 30);
Ninja naruto = new Ninja("Naruto", 25,5,200);
Samurai yasuo = new Samurai ("Yasuo",10,10,25);
gandalf.Attack(naruto);

naruto.Attack(gandalf);

Ninja itachi = new Ninja("Itachi", 50,20, 500,false);
System.Console.WriteLine(naruto.HasStealth);
yasuo.Attack(gandalf);
yasuo.Attack(naruto);

naruto.Attack(yasuo);
System.Console.WriteLine(yasuo.Health);
yasuo.Meditate();