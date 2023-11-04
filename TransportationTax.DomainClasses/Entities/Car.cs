using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationTax.DomainClasses.Entities
{
    public class Car:BaseEntity
    {
        public string CarName { get; set; }=string.Empty;

        public string CarPlateNumber { get; set; } = string.Empty;

        public string CarColor { get; set; }=string.Empty;
    }
}
