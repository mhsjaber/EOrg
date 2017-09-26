using Proggasoft.Data.Hybrid;
using System;
using System.ComponentModel.DataAnnotations;

namespace EOrg.Core.Shop
{
    public class Sell : Entity
    {
        public Guid ProductId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? ColorId { get; set; }
        public int Quantity { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
        public PaymentType PayType { get; set; }
        public Guid? EmiTypeId { get; set; }
        public DateTime CreatedOn { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        [Required]
        public string UpdatedBy { get; set; }
    }
}
