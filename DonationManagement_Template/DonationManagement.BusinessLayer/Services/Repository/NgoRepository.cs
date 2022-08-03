using DonationManagement.BusinessLayer.Interfaces;
using DonationManagement.BusinessLayer.ViewModels;
using DonationManagement.DataLayer;
using DonationManagement.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationManagement.BusinessLayer.Services.Repository
{
    public class NgoRepository : INgoRepository
    {
        private readonly NgoDbContext _ngoContext;
        public NgoRepository(NgoDbContext ngoDbContext)
        {
            _ngoContext = ngoDbContext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ngoId"></param>
        /// <returns></returns>
        public async Task<NgoDetails> FindNgoById(long  ngoId)
        {
            try
            {
                return await _ngoContext.NgoDetails.FindAsync(ngoId);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ngoDetails"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<NgoDetails> Register(NgoDetails ngoDetails, string password)
        {
            try
            {
                var result = await _ngoContext.NgoDetails.AddAsync(ngoDetails);
                await _ngoContext.SaveChangesAsync();
                return ngoDetails;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<NgoDetails> UpdateNgo(RegisterNgoViewModel model)
        {
            var ngo = await _ngoContext.NgoDetails.FindAsync(model.NgoId);
            try
            {
                ngo.Name = model.Name;
                ngo.Username = model.Username;
                ngo.StartedIn = DateTime.Now;
                ngo.Phone = model.Phone;
                ngo.Password = model.Password;
                ngo.IsDeleted = model.IsDeleted;

                _ngoContext.NgoDetails.Update(ngo);
                await _ngoContext.SaveChangesAsync();
                return ngo;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<NgoDetails>> ListAllNgos()
        {
            try
            {
                var result = _ngoContext.NgoDetails.
                OrderByDescending(x => x.StartedIn).Take(10).ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
