using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Comsa_Ionela_Florentina_Lab2.Models;

namespace Comsa_Ionela_Florentina_Lab2.Data
{
    public class Comsa_Ionela_Florentina_Lab2Context : DbContext
    {
        public Comsa_Ionela_Florentina_Lab2Context (DbContextOptions<Comsa_Ionela_Florentina_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Comsa_Ionela_Florentina_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Comsa_Ionela_Florentina_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
