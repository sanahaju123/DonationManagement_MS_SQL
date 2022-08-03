using DonationManagement.BusinessLayer.ViewModels;
using DonationManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationManagement.BusinessLayer.Services.Repository
{
    public interface INgoRepository
    {
        Task<NgoDetails> Register(NgoDetails ngoDetails, string password);
        Task<NgoDetails> FindNgoById(long ngoId);
        Task<NgoDetails> UpdateNgo(RegisterNgoViewModel model);
        Task<IEnumerable<NgoDetails>> ListAllNgos();
    }
}
