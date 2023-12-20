#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations; //for validation 
namespace ChefsAndDishes.Models;
public class Chef
{
    [Key]
    public int ChefId { get; set; }

    [Required]
    public string FirstName { get; set; } 

    [Required]
    public string LastName { get; set; } 

    [Required]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }

    public List<Dish> DishesBy {get; set;} = new List<Dish>();

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    
    public int Age
    {
        get
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - DateOfBirth.Year;

            // Check if the birthday has occurred this year
            if (currentDate.Month < DateOfBirth.Month || (currentDate.Month == DateOfBirth.Month && currentDate.Day < DateOfBirth.Day))
            {
                age--;
            }

            return age;
        }
    }
}