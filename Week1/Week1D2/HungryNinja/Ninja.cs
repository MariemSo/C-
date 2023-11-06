class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;
     
    // add a constructor
    public Ninja()
    {
        calorieIntake = 0;
        FoodHistory = new List<Food>();
    }
    // add a public "getter" property called "IsFull"
    bool IsFull{
        get
        {
            return calorieIntake>1200;
        }
    }
    //build out the Eat method
    public void Eat(Food item)
    {
        if (IsFull == false)
        {
            calorieIntake += item.Calories;
            FoodHistory.Add(item);
            if (item.IsSpicy)
            {
                System.Console.WriteLine("The food is spicy" );
            }
            if ( item.IsSweet)
            {
                System.Console.WriteLine("the food is sweet");
            }
        }
        else 
        {
            System.Console.WriteLine("Enough You are Full");
        }

    }
}

