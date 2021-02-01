using System.ComponentModel.DataAnnotations;

namespace RealEstateManagementAPI.Models
{
    // Mirros the `TransactionStatuses` table
    public class TransactionStatus
    {
        [Key]
        public int StatusId { get; set; }
        public string StatusDescription { get; set; }
    }
}
