using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationManagement.BusinessLayer.ViewModels
{
    public class RegisterDonationViewModel
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
