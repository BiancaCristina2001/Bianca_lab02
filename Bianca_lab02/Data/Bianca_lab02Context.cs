using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bianca_lab02.Models;

namespace Bianca_lab02.Data
{
    public class Bianca_lab02Context : DbContext
    {
        public Bianca_lab02Context (DbContextOptions<Bianca_lab02Context> options)
            : base(options)
        {
        }

        public DbSet<Bianca_lab02.Models.Book> Book { get; set; } = default!;

        public DbSet<Bianca_lab02.Models.Publisher> Publisher { get; set; }
    }
}
