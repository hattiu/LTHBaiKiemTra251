using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Models;
namespace FirstWebMVC.Data

{
    public class LeThiHoaDbContext : DbContext
    {
        public LeThiHoaDbContext (DbContextOptions<LeThiHoaDbContext> options)
            : base(options)
        {
        }

        public DbSet<PhongBan> PhongBan { get; set; } = default!;
    }
}