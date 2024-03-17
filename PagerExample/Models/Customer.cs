namespace PagerExample.Models
{
    public partial class Customer
    {
        [Key]
        [StringLength(15)]
        public string CustomerId { get; set; } = null!;
        [StringLength(75)]
        public string FirstName { get; set; } = null!;
        [StringLength(75)]
        public string LastName { get; set; } = null!;
        [StringLength(500)]
        public string? PhotoUrl { get; set; }
        [StringLength(50)]
        public string? PhoneNo { get; set; }
        [StringLength(75)]
        public string EmailId { get; set; } = null!;        
    }
}
