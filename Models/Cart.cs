using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food2URazor.Models;

public class Cart
{
    [Key]
    public int CartID { get; set; }         //Primary Key

    [Display(Name = "Total Price")]
    [Range(0.00,1000.00)]
    public double TotalPrice { get; set; }

    [Display(Name = "Time Created")]
    [DataType(DataType.Time)]
    [Required]
    public DateTime TimeCreated { get; set; }

    // public List<Item>? Items { get; set; }   //Navigation Property to Items

    // [ForeignKey("OrderID")]
    // public int OrderID { get; set; }        //Foreign Key linking Cart to Order
    // public Order? Order { get; set; }       //Navigation Property to Order

    // [ForeignKey("ShopperID")]
    // public int ShopperID { get; set; }      //Foreign Key linking Cart to Shopper
    // public Shopper? Shopper { get; set; }   //Navigation Property to Shopper
} 