﻿using Proggasoft.Data.Hybrid;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EOrg.Core.Shop
{
    public class Product : Entity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Model { get; set; }
        public int Price { get; set; }
        public Guid SubCategoryId { get; set; }
        public virtual Specification Specification { get; set; }
        public virtual List<CustomField> OtherField { get; set; }
        public virtual List<ProductQuantity> Quantity { get; set; }
        public virtual List<EmiType> Emi { get; set; }
        public bool EmiAvailable { get; set; }
        public DateTime CreatedOn { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        [Required]
        public string UpdatedBy { get; set; }
    }
}
