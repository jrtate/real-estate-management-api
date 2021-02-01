using System.ComponentModel.DataAnnotations;

namespace RealEstateManagementAPI.Models
{
    // Mirros the `Agent` table
    public class Agent
    {
        [Key]
        public int AgentId { get; set; }
        public string Name { get; set; }
        public string AvatarPath { get; set; }
    }
}
