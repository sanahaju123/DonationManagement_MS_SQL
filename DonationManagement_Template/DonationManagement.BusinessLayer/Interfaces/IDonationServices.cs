using DonationManagement.BusinessLayer.ViewModels;
using DonationManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationManagement.BusinessLayer.Interfaces
{
    public interface IDonationServices
    {
        Task<Donation> Register(Donation donation);
        Task<Donation> FindDonationById(long donorId);
        Task<Donation> UpdateDonation(RegisterDonationViewModel model);
        Task<IEnumerable<Donation>> ListAllDonation();
        Task<IEnumerable<Donation>> GetDonationByNgoId(long ngoId);
        Task<IEnumerable<Donation>> GetDonationForDonor(long donorId);

    }
}

