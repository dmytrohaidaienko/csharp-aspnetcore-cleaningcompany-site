using System.ComponentModel.DataAnnotations;

namespace csharp_aspnetcore_cleaningcompany_site.Models
{
    public class CustomerRequest
    {
        public Guid Id { get; set; }
        public String? CustomersName { get; set; }
        public String? CustomersPhone { get; set; }
        public String? CustomersCity { get; set; }
        public String? CustomersAddress { get; set; }
        public String? CustomersPlace { get; set; }
    }
}