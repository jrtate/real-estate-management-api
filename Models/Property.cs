using System.ComponentModel.DataAnnotations;

namespace RealEstateManagementAPI.Models
{
    // Mirros the `Properties` table
    public class Property
    {
        [Key]
        public int PropertyId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string AvatarPath { get; set; }
    }
}
