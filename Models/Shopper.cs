using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food2URazor.Models;

public class Shopper
{
    [Key]
    public int ID { get; set; }  //Primary Key

    [Display(Name = "Username")]
    [StringLength(40, MinimumLength = 4)]
    [Required]
    public string? Username { get; set; }

    [StringLength(20, MinimumLength = 4)]
    [Required]
    public string? Password { get; set; }

    [Display(Name = "Shopper Name")]
    [StringLength(40, MinimumLength = 4)]
    [Required]
    public string? Name { get; set; }

    [Display(Name = "Shopper Email")]
    [StringLength(60, MinimumLength = 4)]
    public string? Email { get; set; }

    [Display(Name = "Shopper Address")]
    [StringLength(40, MinimumLength = 4)]
    [Required]
    public string? Address { get; set; }

    [Display(Name = "Shopper Phone")]
    [Required]
    public long Phone { get; set; }

    // [ForeignKey("OrderID")]
    // public int OrderID { get; set; }    //Foreign Key linking Shopper to Order
    // public Order? Order { get; set; }   //Navigation Property to Order
    // public Cart? Cart { get; set; }      //Navigation Property to Cart
}