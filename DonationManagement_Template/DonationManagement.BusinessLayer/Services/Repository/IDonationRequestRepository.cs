using DonationManagement.BusinessLayer.ViewModels;
using DonationManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationManagement.BusinessLayer.Services.Repository
{
    public interface IDonationRequestRepository
    {
        Task<DonationRequest> Register(DonationRequest donationRequest);
        Task<DonationRequest> FindDonationRequestById(long donationRequestId);
        Task<DonationRequest> UpdateDonationRequest(RegisterDonationRequestViewModel model);
        Task<IEnumerable<DonationRequest>> ListAllDonationRequest();
        Task<IEnumerable<DonationRequest>> GetDonationRequestByNgoId(long ngoId);
        Task<IEnumerable<DonationRequest>> GetDonationRequestForDonor(long donorId);
    }
}
