using Proggasoft.Data.Hybrid;
using System;
using System.ComponentModel.DataAnnotations;

namespace EOrg.Core.Shop
{
    public class Specification : Entity
    {
        public double Weight { get; set; }
        public double DisplaySize { get; set; }
        public double FrontCamera { get; set; }
        public double BackCamera { get; set; }
        public double CPUSpeed { get; set; }
        public double RAM { get; set; }
        public double ROM { get; set; }
        public string Battery { get; set; }
        public string SIMCard { get; set; }
        public string Processor { get; set; }
        public string Warranty { get; set; }
        public Guid BrandID { get; set; }
    }
}
