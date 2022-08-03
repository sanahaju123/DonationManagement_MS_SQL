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
    public class DonationRequestServices : IDonationRequestServices
    {
        private readonly IDonationRequestRepository _donationRequestRepository;
        private readonly NgoDbContext _ngoContext;

        public DonationRequestServices(IDonationRequestRepository donationRequestRepository, NgoDbContext ngoDbContext)
        {
            _donationRequestRepository = donationRequestRepository;
            _ngoContext = ngoDbContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donationRequestId"></param>
        /// <returns></returns>
        public async Task<DonationRequest> FindDonationRequestById(long donationRequestId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donationRequestDetails"></param>
        /// <returns></returns>
        public async Task<DonationRequest> Register(DonationRequest donationRequestDetails)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<DonationRequest> UpdateDonationRequest(RegisterDonationRequestViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<DonationRequest>> ListAllDonationRequest()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ngoId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<DonationRequest>> GetDonationRequestByNgoId(long ngoId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donorId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<DonationRequest>> GetDonationRequestForDonor(long donorId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}

