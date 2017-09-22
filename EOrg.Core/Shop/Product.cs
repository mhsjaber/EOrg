using Proggasoft.Data.Hybrid;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOrg.Core.Shop
{
    public class Product : Entity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Model { get; set; }
        public Guid SubCategoryID { get; set; }
        public virtual Specification Specification { get; set; }
        public virtual List<CustomField> OtherField { get; set; }
        public virtual List<ColorItem> Color { get; set; }
        public bool EMIAvailable { get; set; }
        public DateTime CreatedOn { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        [Required]
        public string UpdatedBy { get; set; }
    }
}
