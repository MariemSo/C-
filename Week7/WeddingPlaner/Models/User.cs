#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations; //for validation 
using System.ComponentModel.DataAnnotations.Schema;
using WeddingPlaner.Models; //new Import for table

public class User
{
    [Key]
    public int UserId { get; set; }

    //FirstName
    [Required(ErrorMessage = "Please enter a First Name")]
    [MinLength(3, ErrorMessage = "First Name must be at least 2 characters")]
    [Display(Name="First Name")]
    public string FirstName { get; set; }

     //Last
    [Required(ErrorMessage = "Please enter a Last Name")]
    [MinLength(3, ErrorMessage = "Last Name must be at least 2 characters")]
    [Display(Name="Last Name")]
    public string LastName { get; set; } 

    //Email
    [Required(ErrorMessage = "Please enter your Email")]
    [EmailAddress(ErrorMessage = "Please enter a valid Email")]
    public string Email { get; set; }

    //Password
    [Required(ErrorMessage = "Please enter a password")]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
    public string Password { get; set; }

    //Confirm Password
    [NotMapped]//don't add to DB
    [Required(ErrorMessage = "Please enter your password again")]
    [Compare("Password", ErrorMessage = "Passwords do not match")]
    [DataType(DataType.Password)]
    [Display(Name="PW Confirm")]
    public string ConfirmPassword { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    //Navigation Property
    public List<Wedding> MyWeddings { get; set; } = new List<Wedding>(); //One to Many User weddings
    public List<Guest> Attending { get; set; } = new List<Guest>();//One to Many User Orders
}