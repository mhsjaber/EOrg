using Proggasoft.Data.Hybrid;
using System;

namespace EOrg.Core.Shop
{
    public class ProductColor : Entity
    {
        public Guid? ColorID { get; set; }
        public int Quantity { get; set; }
    }
}
