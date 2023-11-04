using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportationTax.DomainClasses.Entities
{
    public class PayToll:BaseEntity
    {

        public string PayTollName { get; set; } = string.Empty;

        public int PayTollCode { get; set; }

        public int PayTollDistance { get; set; }


    }
}
