#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LoginReg.Models;

public class User
{
    [Key]
    public int UserId { get; set; }

    [Required]
    [MinLength(2)]
    public string FirstName { get; set; } 

    [Required]
    [MinLength(2)]
    public string LastName { get; set; } 

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
    public string Password { get; set; }

    [NotMapped]
    [Required(ErrorMessage = "Please enter your password again")]
    [Compare("Password", ErrorMessage = "Passwords do not match")]
    [DataType(DataType.Password)]
    [Display(Name="PW Confirm")]
    public string Confirm { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}