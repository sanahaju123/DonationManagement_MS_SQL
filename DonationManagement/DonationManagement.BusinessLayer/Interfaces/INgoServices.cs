using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonationManagement.Entities;
using DonationManagement.BusinessLayer.ViewModels;

namespace DonationManagement.BusinessLayer.Interfaces
{
    public interface INgoServices
    {
        Task<NgoDetails> Register(NgoDetails ngoDetails, string password);
        Task<NgoDetails> FindNgoById(long ngoId);
        Task<NgoDetails> UpdateNgo(RegisterNgoViewModel model);
        Task<IEnumerable<NgoDetails>> ListAllNgos();

    }
}
