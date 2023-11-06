class Buffet
{
    public List<Food> Menu;
     
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Peking Duck", 1000, false, false),
            new Food("Sushi", 120, false, false),
            new Food("Chili Crab", 1500, true, true),
            new Food("Satay", 800, true, false),
            new Food("Dim Sum", 1900, false, false),
            new Food("Mango Rice", 750, false, true),
            new Food("Takoyaki", 452, false, false),

        };
    }
     
    public Food Serve()
    {
        Random rand = new Random();
        Food plate = Menu[rand.next(0,6)];
        return plate;
    }
}

