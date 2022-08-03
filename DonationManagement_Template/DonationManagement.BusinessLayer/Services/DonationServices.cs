using DonationManagement.BusinessLayer.Interfaces;
using DonationManagement.BusinessLayer.Services.Repository;
using DonationManagement.BusinessLayer.ViewModels;
using DonationManagement.DataLayer;
using DonationManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationManagement.BusinessLayer.Services
{
    public class DonationServices:IDonationServices
    {
        private readonly IDonationRepository _donationRepository;
        private readonly NgoDbContext _ngoContext;

        public DonationServices(IDonationRepository donationRepository, NgoDbContext ngoDbContext)
        {
            _donationRepository = donationRepository;
            _ngoContext = ngoDbContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donationId"></param>
        /// <returns></returns>
        public async Task<Donation> FindDonationById(long donationId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donationDetails"></param>
        /// <returns></returns>
        public async Task<Donation> Register(Donation donationDetails)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<Donation> UpdateDonation(RegisterDonationViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Donation>> ListAllDonation()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ngoId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Donation>> GetDonationByNgoId(long ngoId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donorId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Donation>> GetDonationForDonor(long donorId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}


