using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportationTax.DomainClasses.Entities;

namespace TransportationTax.Services.Contracts
{

    /// <summary>
    /// by this interface managers can define bases of tax rulls
    /// </summary>
    public interface IManagmentService
    {

        #region Crud Opration Of CongestionTax

        /// <summary>
        /// Get The List Of CongestionTax such as Time And amount of tax
        /// </summary>
        /// <returns>List<CongestionTax></returns>
        Task<List<CongestionTax>> GetAllCongestionTaxAsync();

        /// <summary>
        /// Get a single record by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>CongestionTax</returns>
        Task<CongestionTax> GetCongestionTaxAsync(int Id);

        /// <summary>
        /// Add a record of Congestion Tax to the list
        /// </summary>
        /// <param name="congestionTax"></param>
        /// <returns>bool</returns>
        Task<bool> AddCongestionTax(CongestionTax congestionTax);

        /// <summary>
        /// Delete a CongestionTax record 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>bool</returns>
        Task<bool> DeleteCongestionTaxAsync(int Id);

        /// <summary>
        /// Update existing record of CongestionTax 
        /// </summary>
        /// <param name="congestionTax"></param>
        /// <returns>Updatetd CongestionTax</returns>
        Task<CongestionTax> UpdateCongestionTaxAsync(CongestionTax congestionTax);

        #endregion




    }
}
