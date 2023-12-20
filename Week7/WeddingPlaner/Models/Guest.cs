#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations; //for validation 
using System.ComponentModel.DataAnnotations.Schema;
namespace WeddingPlaner.Models;

public class Guest
{
    [Key]
    public int GuestId { get; set; }

    //Foreign Key
    [Required]
    public int WeddingId { get; set; }
    public Wedding? Wedding { get; set; }//One To Many Weddings Guests

    //Foreign Key
    [Required]
    public int UserId { get; set; }
    public User? Attendee {get; set; } //One To Many Users Guests

    public bool RSVPStatus { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

}