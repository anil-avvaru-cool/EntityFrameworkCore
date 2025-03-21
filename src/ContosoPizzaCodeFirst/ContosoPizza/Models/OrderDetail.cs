namespace ContosoPizza.Models
{
    /// <summary>
    /// Intersection entity for many to many relationship
    /// </summary>
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Qunatity { get; set; }

        // Forigen key relationship id, optional
        public int ProductId { get; set; }
        
        // Forigen key relationship id, optional
        public int OrderId { get; set; }

        public Order Order { get; set; } = null!;

        public Product Product { get; set; } = null!;
    }
}