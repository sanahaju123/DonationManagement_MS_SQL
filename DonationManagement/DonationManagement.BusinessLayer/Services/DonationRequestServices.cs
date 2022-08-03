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
            return await _donationRequestRepository.FindDonationRequestById(donationRequestId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donationRequestDetails"></param>
        /// <returns></returns>
        public async Task<DonationRequest> Register(DonationRequest donationRequestDetails)
        {
            return await _donationRequestRepository.Register(donationRequestDetails);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<DonationRequest> UpdateDonationRequest(RegisterDonationRequestViewModel model)
        {
            return await _donationRequestRepository.UpdateDonationRequest(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<DonationRequest>> ListAllDonationRequest()
        {
            return await _donationRequestRepository.ListAllDonationRequest();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ngoId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<DonationRequest>> GetDonationRequestByNgoId(long ngoId)
        {
            return await _donationRequestRepository.GetDonationRequestByNgoId(ngoId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donorId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<DonationRequest>> GetDonationRequestForDonor(long donorId)
        {
            return await _donationRequestRepository.GetDonationRequestForDonor(donorId);
        }
    }
}

