#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace LoginReg.Models;

public class LoginUser
{

    [Required]
    [EmailAddress]
    public string LogEmail { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
    public string LogPassword { get; set; }

}