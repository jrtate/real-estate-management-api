using System;
using System.ComponentModel.DataAnnotations;

namespace RealEstateManagementAPI.Models
{
    public class Deposits
    {
        [Key]
        public int DepositId { get; set; }
        public DateTime MoveInDate { get; set; }
        public decimal Rent { get; set; }
        public decimal Deposit { get; set; }
        public int Active { get; set; }
        public Agent Agent { get; set; }
        public Property Property { get; set; }
        public TransactionStatus TransactionStatus{ get; set; }

        // TODO: DEPOSIT STATUSES TABLE (optional to many)
    }
}
