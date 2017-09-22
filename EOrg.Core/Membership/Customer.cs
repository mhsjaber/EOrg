using Proggasoft.Data.Hybrid;
using System;

namespace EOrg.Core.Membership
{
    public class Customer : Entity
    {
        public string FullName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string SpouseName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NIDNumber { get; set; }
        public string Occupation { get; set; }
        public string SpouseOccupation { get; set; }
        public int MonthlyIncome { get; set; }
        public int MonthlyExpenditure { get; set; }
        public int FamilyMembers { get; set; }
        public virtual Address PresentAddress { get; set; }
        public virtual Address PermanentAddress { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
