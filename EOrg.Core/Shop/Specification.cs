using Proggasoft.Data.Hybrid;
using System;

namespace EOrg.Core.Shop
{
    public class Specification : Entity
    {
        public double? Weight { get; set; }
        public double? DisplaySize { get; set; }
        public double? FrontCamera { get; set; }
        public double? BackCamera { get; set; }
        public double? CpuSpeed { get; set; }
        public double? Ram { get; set; }
        public double? Rom { get; set; }
        public string Battery { get; set; }
        public string SimCard { get; set; }
        public string Processor { get; set; }
        public string Warranty { get; set; }
        public Guid BrandId { get; set; }
    }
}
