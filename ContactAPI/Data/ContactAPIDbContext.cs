using ContactAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactAPI.Data
{
    public class ContactAPIDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public ContactAPIDbContext(DbContextOptions options) : base(options)
        {

        }
        
            
        
    }
}
