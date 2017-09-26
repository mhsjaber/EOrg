using Proggasoft.Data.Hybrid;
using System;

namespace EOrg.Core.Shop
{
    public class ProductQuantity : Entity
    {
        public Guid? ColorId { get; set; }
        public int Quantity { get; set; }
    }
}
