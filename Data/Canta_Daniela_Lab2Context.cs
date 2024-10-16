using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Canta_Daniela_Lab2.Models;

namespace Canta_Daniela_Lab2.Data
{
    public class Canta_Daniela_Lab2Context : DbContext
    {
        public Canta_Daniela_Lab2Context (DbContextOptions<Canta_Daniela_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Canta_Daniela_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Canta_Daniela_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Canta_Daniela_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
