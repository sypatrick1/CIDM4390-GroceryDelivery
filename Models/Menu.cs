using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food2URazor.Models;

public class Menu
{
    [Key]
    public int menuID { get; set; }   //Primary Key

    [Display(Name = "Menu Name")]
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Name { get; set; }

    public List<Item>? Items { get; set; }       //Navigation Property to Items
    [ForeignKey("RestaurantID")]
    public int RestaurantID { get; set; }       //Foreign Key linking Menu to Restaurant
    public Restaurant? Restaurant { get; set; } //Navigation Property to Restaurant
}