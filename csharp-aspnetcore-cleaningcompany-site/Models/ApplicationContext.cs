using Microsoft.EntityFrameworkCore;

namespace csharp_aspnetcore_cleaningcompany_site.Models
{
    public class ApplicationContext:DbContext
    {
        public DbSet<CustomerRequest> CustomersRequests { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}