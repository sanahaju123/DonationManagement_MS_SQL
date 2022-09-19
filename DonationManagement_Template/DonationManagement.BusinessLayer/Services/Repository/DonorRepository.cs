using DonationManagement.BusinessLayer.ViewModels;
using DonationManagement.DataLayer;
using DonationManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationManagement.BusinessLayer.Services.Repository
{
    public class DonorRepository : IDonorRepository
    {
        private readonly NgoDbContext _ngoContext;
        public DonorRepository(NgoDbContext ngoDbContext)
        {
            _ngoContext = ngoDbContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donorId"></param>
        /// <returns></returns>
        public async Task<Donor> FindDonorById(long donorId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="donor"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<Donor> Register(Donor donor, string password)
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

