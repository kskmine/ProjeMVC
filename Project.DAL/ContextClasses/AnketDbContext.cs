using Microsoft.EntityFrameworkCore;
using Project.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
   public class AnketDbContext:DbContext
    {
        public AnketDbContext(DbContextOptions<AnketDbContext> options) : base(options)
        {

        }
        public DbSet<Anket> Ankets { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Sirket> Sirkets { get; set; }
        public DbSet<Statu> Status { get; set; }

    }
}
