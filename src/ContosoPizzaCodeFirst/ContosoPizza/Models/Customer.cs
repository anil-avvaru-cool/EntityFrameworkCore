using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoPizza.Models
{
    /// <summary>
    /// One to many relationship
    /// </summary>
    public class Customer
    {
        public int Id { get; set; }

        // EF core creates as Non Nullable  column
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        // Nullable, EF core creates as nullable column
        public string? Address { get; set; }
        public string? Phone { get; set; }
        //public string? Email { get; set; }

        public ICollection<Order> Orders { get; set; } = null!;
    }
}
