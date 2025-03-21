using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorWebAppEFCore.Data;
using RazorWebAppEFCore.Models;

namespace RazorWebAppEFCore.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly RazorWebAppEFCore.Data.ContosoPizzaPart1Context _context;

        public IndexModel(RazorWebAppEFCore.Data.ContosoPizzaPart1Context context)
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
