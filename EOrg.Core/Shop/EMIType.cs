using Proggasoft.Data.Hybrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOrg.Core.Shop
{
    public class EMIType : Entity
    {
        public int Price { get; set; }
        public int Installment { get; set; }
    }
}
