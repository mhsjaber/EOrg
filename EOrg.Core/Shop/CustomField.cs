using Proggasoft.Data.Hybrid;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOrg.Core.Shop
{
    public class CustomField : Entity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Value { get; set; }
    }
}
