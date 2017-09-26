using Proggasoft.Data.Hybrid;
using System;
using System.ComponentModel.DataAnnotations;

namespace EOrg.Core.Shop
{
    public class Installmet : Entity
    {
        public Guid SellId { get; set; }
        public int PaidAmount { get; set; }
        public string Remark { get; set; }
        public DateTime CreatedOn { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        [Required]
        public string UpdatedBy { get; set; }
    }
}
