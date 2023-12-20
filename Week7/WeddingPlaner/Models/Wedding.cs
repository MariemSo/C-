#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations; //for validation 
using System.ComponentModel.DataAnnotations.Schema;
namespace WeddingPlaner.Models;

public class Wedding
{
    [Key]
    public int WeddingId { get; set; }

    //Foreign Key
    [Required]
    public int UserId { get; set; }

    //Navigation Property
    public User? Planner { get; set; }

    //WedderOne
    [Required(ErrorMessage ="Please add a Wedder")]
    [Display(Name="Wedder One")]
    public string WedderOne { get; set; }

    //WedderTwo
    [Required(ErrorMessage ="Please add a second Wedder")]
    [Display(Name="Wedder Two ")]
    public string WedderTwo { get; set; }
    
    //Date 
    //Wedding date must be in the future
    [Required(ErrorMessage = "Please add Date")]
    [FutureDate(ErrorMessage = "Wedding date must be in the future")]
    [Display(Name="Date ")]
    public DateTime WeddingDate { get; set; }

    //Address
    [Required(ErrorMessage ="Please add an Address!")]
    [DataType(DataType.MultilineText)]
    public string Address { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    //Navigation Property
    public List<Guest> Guests { get; set; }= new List<Guest>();

}
public class FutureDateAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        DateTime date = (DateTime)value;
        return date > DateTime.Now;
    } 
}