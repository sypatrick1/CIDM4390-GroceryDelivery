using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food2URazor.Models;

public class Driver
{
    [Key]
    public int DriverID { get; set; }   //Primary Key

    [Display(Name = "Driver Name")]
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Name { get; set; }

    [Display(Name = "Driver Phone")]
    [Required]
    public long Phone { get; set; }

    // [ForeignKey("OrderID")]
    // public int OrderID { get; set; }    //Foreign Key linking Driver to Order
    // public Order? Order { get; set; }   //Navigation Property to Order
}