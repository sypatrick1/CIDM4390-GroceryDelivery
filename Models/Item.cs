using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food2URazor.Models;

public class Item
{
    [Key]
    public int ItemID { get; set; }     //Primary Key

    [Display(Name = "Item Name")]
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Name { get; set; }

    [Display(Name = "Description")]
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Description { get; set; }

    [Required]
    [Range (0.00,1000.00)]
    public double Price { get; set; }

    [ForeignKey("MenuID")]
    public int MenuID { get; set; }     //Foreign Key linking Item to Menu
    public Menu? Menu { get; set; }     //Navigation Property for Menu

    // [ForeignKey("CartID")]
    // public int CartID { get; set; }     //Foreign Key linking Item to Cart
    // public Cart? Cart { get; set; }     //Navigation Property for Cart
}