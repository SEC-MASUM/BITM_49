using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalMealManager.Models
{
    public class PMMContext : DbContext
    {
        public PMMContext(DbContextOptions<PMMContext> options): base(options)
        {

        }

        public DbSet<Member> Members { get; set; }
        public DbSet<MemberPay> MemberPays { get; set; }
        public DbSet<DailyUpdate> DailyUpdates { get; set; }
    }
}
