using Proggasoft.Data.Hybrid;
using System;
using System.ComponentModel.DataAnnotations;

namespace EOrg.Core.Shop
{
    public class Brand : Entity
    {
        [Required]
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        [Required]
        public string UpdatedBy { get; set; }
    }
}
