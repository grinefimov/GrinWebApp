using GrinWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GrinWebApp.Data
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contact { get; set; }
    }
}
