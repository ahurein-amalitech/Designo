using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Designo.Data
{
    public class DesignoContext  : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Path.Combine(Environment.CurrentDirectory, "Designo.db");
            string connection = $"FileName={path}";

            optionsBuilder.UseSqlite(connection);
        }

        public DbSet<Designo.Models.Contact> Contact { get; set; } = default!;
    }
}
