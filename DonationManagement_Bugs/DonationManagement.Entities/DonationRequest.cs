using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DonationManagement.Entities
{
    public class DonationRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long DonationRequestId { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsDeleted { get; set; }
        public long NgoId { get; set; }
        public long DonorId { get; set; }
        public long DonationId { get; set; }

    }
}
