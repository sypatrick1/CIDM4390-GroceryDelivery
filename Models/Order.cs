using System.ComponentModel.DataAnnotations;

namespace Food2URazor.Models;

public class Order
{
    public int OrderID { get; set; }            //Primary Key

    [Display(Name = "Order Status")]
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Status { get; set; }

    // public Cart? Cart { get; set; }             //Navigation Property to Cart

    // public Shopper? Shopper { get; set; }       //Navigation Property for Shopper

    // public Restaurant? Restaurant { get; set; } //Navigation Property to Restaurant

    // public Driver? Driver { get; set; }         //Navigation Property for Driver
}