#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations; //for validation 
namespace CRUDelicious.Models;

public class Dishes
{
    [Key]
   [Required]
    public int DishId { get; set; }

   [Required]
    public string Name { get; set; } 

   [Required]
    public string Chef { get; set; }

   [Required]
    [Range(1,5, ErrorMessage = "Please enter a value between 1 and 5")]
    public int Tastiness { get; set; }

   [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
    public int Calories { get; set; }

   [Required]
    public string Description { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}