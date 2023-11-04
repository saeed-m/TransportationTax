using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportationTax.DataLayer.dbcontext;
using TransportationTax.DomainClasses.Entities;
using TransportationTax.Services.Contracts;

namespace TransportationTax.Services.Services
{
    public class ManagmentService : IManagmentService
    {
        public  ApplicationDbContext dbContext;
        public ManagmentService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        #region CongestionTax Crud Oprations


        public async Task<bool> AddCongestionTax(CongestionTax congestionTax)
        {

            try
            {
               await dbContext.congestionTaxes.AddAsync(congestionTax);
               await dbContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                //log the exception

                return false;
               
            }
            

        }

        public async Task<bool> DeleteCongestionTaxAsync(int Id)
        {
            var existRecord=await dbContext.congestionTaxes.FindAsync(Id);
            if (existRecord != null)
            {
                //delete the record
                dbContext.congestionTaxes.Remove(existRecord);
                await dbContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<List<CongestionTax>> GetAllCongestionTaxAsync()
        {
            return await dbContext.congestionTaxes.ToListAsync();
        }

        public async Task<CongestionTax> GetCongestionTaxAsync(int Id)
        {
            var existRecord= await dbContext.congestionTaxes.FirstOrDefaultAsync(i=>i.Id==Id);

            if (existRecord != null)
            {
                return existRecord;
            }
            return new CongestionTax();

        }

        public async Task<CongestionTax> UpdateCongestionTaxAsync(CongestionTax congestionTax)
        {
            var existRecord = await dbContext.congestionTaxes.FirstOrDefaultAsync(i => i.Id == congestionTax.Id);
            if(existRecord != null)
            {
                existRecord.FromTime = congestionTax.FromTime;
                existRecord.ToTime = congestionTax.ToTime;
                existRecord.TaxAmount= congestionTax.TaxAmount;
                await dbContext.SaveChangesAsync();
                return existRecord;
            }

            return new CongestionTax();


        }

        #endregion



    }
}
