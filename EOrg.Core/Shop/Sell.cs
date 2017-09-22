using Proggasoft.Data.Hybrid;
using System;
using System.ComponentModel.DataAnnotations;

namespace EOrg.Core.Shop
{
    public class Sell : Entity
    {
        public Guid ProductID { get; set; }
        public Guid CustomerID { get; set; }
        public Guid ColorID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public PaymentType PayType { get; set; }
        public Guid EMITypeID { get; set; }
        public int PayAmount { get; set; }
        public DateTime CreatedOn { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        [Required]
        public string UpdatedBy { get; set; }
    }
}
