using Proggasoft.Data.Hybrid;

namespace EOrg.Core
{
    public class Address : Entity
    {
        public string District { get; set; }
        public string Thana { get; set; }
        public string PostOffice { get; set; }
        public string Village { get; set; }
        public string House { get; set; }
    }
}
