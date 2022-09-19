using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DonationManagement.Entities
{
    public class Donation
    {
        public long DonationId { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }
        public long NgoId { get; set; }
        public long DonorId { get; set; }
        
    }
}
   