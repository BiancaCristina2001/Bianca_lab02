﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bianca_lab02.Data;
using Bianca_lab02.Models;

namespace Bianca_lab02.Pages.Publisher
{
    public class IndexModel : PageModel
    {
        private readonly Bianca_lab02.Data.Bianca_lab02Context _context;

        public IndexModel(Bianca_lab02.Data.Bianca_lab02Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
