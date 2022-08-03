using DonationManagement.BusinessLayer.ViewModels;
using DonationManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationManagement.BusinessLayer.Services.Repository
{
    public interface IDonorRepository
    {
        Task<Donor> Register(Donor donor, string password);
        Task<Donor> FindDonorById(long donorId);
        Task<Donor> UpdateDonor(RegisterDonorViewModel model);
        Task<IEnumerable<Donor>> ListAllDonors();
        Task<IEnumerable<Donor>> GetDonorByNgoId(long ngoId);
    }
}
