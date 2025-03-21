﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly RazorWebAppEFCore.Data.ContosoPizzaPart1Context _context;

        public DetailsModel(RazorWebAppEFCore.Data.ContosoPizzaPart1Context context)
        {
            _context = context;
        }

        public Product Product { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            else
            {
                Product = product;
            }
            return Page();
        }
    }
}
