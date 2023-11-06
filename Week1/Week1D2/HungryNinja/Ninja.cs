class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;
     
    // add a constructor
    public void ninja()
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
            calorieIntake += item.Calories
        }
    }
}

