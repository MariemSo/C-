#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations; //for validation 
namespace ChefsAndDishes.Models;
public class Dish
{
    [Key]
    public int DishId { get; set; }

    [Required]
    public int ChefId {get; set;}

    [Required]
    public string Name { get; set; } 

    [Required]
    [Range(0, int.MaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
    public int Calories { get; set; } 

    [Required]
    [Range(1, 5)]
    public int Tastiness { get; set; }

    public Chef? Cook {get; set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}