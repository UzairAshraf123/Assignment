//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.SystemCustomFields = new HashSet<SystemCustomField>();
        }
    
        public int EmpId { get; set; }
        public string SocialInsuranceNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public Nullable<int> GenderId { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public Nullable<int> ProvinceId { get; set; }
        public string PostalCode { get; set; }
        public Nullable<int> CountryId { get; set; }
        public string Telephone1 { get; set; }
        public string Telephone2 { get; set; }
        public string WorkTelephone { get; set; }
        public Nullable<int> BankId { get; set; }
        public string BankTransitNumber { get; set; }
        public string BankAccountNumber { get; set; }
        public string PreferredLanguageId { get; set; }
        public Nullable<bool> PrintStatementInd { get; set; }
        public string SourceDocVerifiedInd { get; set; }
        public string UserId { get; set; }
        public string WorkEmailAddress { get; set; }
        public string PersonalEmailAddress { get; set; }
        public string EmailPreferenceFlag { get; set; }
        public Nullable<bool> WebT4ConsentInd { get; set; }
        public Nullable<System.DateTime> BenefitEligibilityDate { get; set; }
        public string BenefitCarrierNumber { get; set; }
        public string WorkTelephoneExt { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual OrgGender OrgGender { get; set; }
        public virtual OrgProvince OrgProvince { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemCustomField> SystemCustomFields { get; set; }
    }
}
