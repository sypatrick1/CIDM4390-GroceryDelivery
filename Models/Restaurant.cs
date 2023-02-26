using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food2URazor.Models;

public class Restaurant
{
    [Key]
    public int restaurantID { get; set; }   //Primary Key

    [Display(Name = "Restaurant Name")]
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Name { get; set; }

    [Display(Name = "Restaurant Address")]
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Address { get; set; }

    [Display(Name = "Restaurant Phone")]
    [Required]
    public long Phone { get; set; }

    public Menu? Menu { get; set; }     //Navigation Property to Menu
    
    // [ForeignKey("OrderID")]
    // public int OrderID { get; set; }    //Foreign Key linking Restaurant to Order 
    // public Order? Order { get; set; }   //Navigation Property to Orders
}