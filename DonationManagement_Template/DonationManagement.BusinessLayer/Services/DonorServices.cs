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
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donorDetails"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<Donor> Register(Donor donorDetails, string password)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<Donor> UpdateDonor(RegisterDonorViewModel model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Donor>> ListAllDonors()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ngoId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Donor>> GetDonorByNgoId(long ngoId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}

