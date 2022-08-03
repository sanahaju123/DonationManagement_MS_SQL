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
    public class DonorServices:IDonorServices
    {
        private readonly IDonorRepository _donorRepository;
        private readonly NgoDbContext _ngoContext;

        public DonorServices(IDonorRepository donorRepository, NgoDbContext ngoDbContext)
        {
            _donorRepository = donorRepository;
            _ngoContext = ngoDbContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ngoId"></param>
        /// <returns></returns>
        public async Task<Donor> FindDonorById(long ngoId)
        {
            return await _donorRepository.FindDonorById(ngoId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donorDetails"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<Donor> Register(Donor donorDetails, string password)
        {
            return await _donorRepository.Register(donorDetails, password);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<Donor> UpdateDonor(RegisterDonorViewModel model)
        {
            return await _donorRepository.UpdateDonor(model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Donor>> ListAllDonors()
        {
            return await _donorRepository.ListAllDonors();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ngoId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Donor>> GetDonorByNgoId(long ngoId)
        {
            return await _donorRepository.GetDonorByNgoId(ngoId);
        }
    }
}

