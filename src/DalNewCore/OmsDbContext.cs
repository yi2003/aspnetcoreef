using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelCo;

namespace DalCore
{
    public class OmsDbContext: Microsoft.EntityFrameworkCore.DbContext

    {
        public OmsDbContext(DbContextOptions<OmsDbContext> options):base(options)
        {

        }

        public DbSet<Order> Orders { get; set; }
        protected override  void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Order>().ToTable("Orders");
        }
    }

    
}
