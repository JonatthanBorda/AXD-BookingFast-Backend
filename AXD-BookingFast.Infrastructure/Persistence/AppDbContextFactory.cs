using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Infrastructure.Persistence
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=Jonathan_Borda; Database=AXDBookingFast_DB; Trusted_Connection=True; MultipleActiveResultSets=true; TrustServerCertificate=True");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
