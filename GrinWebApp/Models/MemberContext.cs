using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GrinWebApp.Models
{
    public class MemberContext : DbContext
    {
        public MemberContext(DbContextOptions<MemberContext> options)
            : base(options)
        {
        }

        public DbSet<GrinWebApp.Models.Member> Member { get; set; }
    }
}