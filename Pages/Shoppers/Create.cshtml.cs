using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Food2URazor.Data;
using Food2URazor.Models;

namespace Food2URazor.Pages_Shoppers
{
    public class CreateModel : PageModel
    {
        private readonly Food2URazor.Data.Food2URazorContext _context;

        public CreateModel(Food2URazor.Data.Food2URazorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Shopper Shopper { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Shoppers == null || Shopper == null)
            {
                return Page();
            }

            _context.Shoppers.Add(Shopper);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
