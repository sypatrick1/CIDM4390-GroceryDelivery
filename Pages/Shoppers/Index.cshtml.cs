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
    public class IndexModel : PageModel
    {
        private readonly Food2URazor.Data.Food2URazorContext _context;

        public IndexModel(Food2URazor.Data.Food2URazorContext context)
        {
            _context = context;
        }

        public IList<Shopper> Shopper { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Shoppers != null)
            {
                Shopper = await _context.Shoppers.ToListAsync();
            }
        }
    }
}
