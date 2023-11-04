using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationTax.DomainClasses.Entities
{
    public class CongestionTax:BaseEntity
    {
        [Required(ErrorMessage = "From Time is Required")]
        public DateTime FromTime { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "To Time is Required")]
        public DateTime ToTime { get; set;}= DateTime.Now;

        [Required(ErrorMessage = "Tax Amount is Required")]
        public double TaxAmount { get; set; } = 0;



    }
}
