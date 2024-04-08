using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebRasorTask.DAL;
using WebRasorTask.Models;

namespace WebRasorTask.Pages.ProductMaster
{
    public class IndexModel : PageModel
    {
        private readonly WebRasorTask.DAL.AppDbContext _context;

        public IndexModel(WebRasorTask.DAL.AppDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
