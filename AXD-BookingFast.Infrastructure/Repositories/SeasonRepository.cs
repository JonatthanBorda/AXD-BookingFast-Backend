using AXD_BookingFast.Domain.Entities;
using AXD_BookingFast.Domain.Interfaces;
using AXD_BookingFast.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AXD_BookingFast.Infrastructure.Repositories
{
    public class SeasonRepository : Repository<Season>, ISeasonRepository
    {
        public SeasonRepository(AppDbContext context) : base(context) { }

        public async Task<Season?> GetSeasonForDateAsync(DateTime date)
        {
            return await _context.Seasons
                .FirstOrDefaultAsync(s => date >= s.StartDate && date <= s.EndDate);
        }
    }
}
