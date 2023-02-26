using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Food2URazor.Data;
using Food2URazor.Models;

namespace Food2URazor.Pages_Shoppers
{
    public class DeleteModel : PageModel
    {
        private readonly Food2URazor.Data.Food2URazorContext _context;

        public DeleteModel(Food2URazor.Data.Food2URazorContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Shopper Shopper { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Shoppers == null)
            {
                return NotFound();
            }

            var shopper = await _context.Shoppers.FirstOrDefaultAsync(m => m.ID == id);

            if (shopper == null)
            {
                return NotFound();
            }
            else 
            {
                Shopper = shopper;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Shoppers == null)
            {
                return NotFound();
            }
            var shopper = await _context.Shoppers.FindAsync(id);

            if (shopper != null)
            {
                Shopper = shopper;
                _context.Shoppers.Remove(Shopper);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
