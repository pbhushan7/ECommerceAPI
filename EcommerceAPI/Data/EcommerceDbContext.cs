using EcommerceAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EcommerceAPI.Data
{
    public class EcommerceDbContext : DbContext
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
