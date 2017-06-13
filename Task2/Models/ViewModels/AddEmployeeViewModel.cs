using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task2.Models.ViewModels
{
    public class AddEmployeeViewModel
    {
        public IEnumerable<OrgDataAccess> ScreenElements { get; set; }

        public IEnumerable<UserElementPermission> UserPermissions { get; set; }

        public IEnumerable<TableDataAccess> Fields { get; set; }

        [Display(Name = "Employee ID ")]
        public int EmployeeID { get; set; }

        [Display(Name = "Social Insurance Number ")]
        
        [RegularExpression("([0-9])+", ErrorMessage = "Enter only numeric value..")]
        [StringLength(9, ErrorMessage = "Max length 9")]
        public string SIN { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "First Name ")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Identify as")]
        public int? GenderID { get; set; }

        [Display(Name = "Birth Date ")]
        public DateTime? DOB { get; set; }

        [Display(Name = "Address ")]
        public string Address1 { get; set; }

        [Display(Name = "Address ")]
        public string Address2 { get; set; }

        [Display(Name = "City ")]
        public string City { get; set; }

        [Display(Name = "Province")]
        public int? ProvinceID { get; set; }
        
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [Display(Name = "Country")]
        public int? CountryID { get; set; }

        [Display(Name = "Telephone ")]
        [StringLength(10, ErrorMessage = "Max length 10")]
        public string Telephone1 { get; set; }

        [Display(Name = "Alternate Telephone")]
        [StringLength(10, ErrorMessage = "Max length 10")]
        public string Telephone2 { get; set; }

        [Display(Name = "Work Telephone")]
        [StringLength(10, ErrorMessage = "Max length 10")]
        public string WorkTelephone { get; set; }

        [Display(Name = "Ext.")]
        [StringLength(8, ErrorMessage = "Max length 8")]
        public string WorkTelephoneExt { get; set; }

        [Display(Name = "Bank")]
        public int? BandID { get; set; }

        [Display(Name = "Transit Number")]
        public string TransactionNumber { get; set; }

        [Display(Name = "Account Number ")]
        public string AccountNumber { get; set; }

        [Display(Name = "Preferred Language")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "Max length 1")]
        public string PreferedLanguageID { get; set; }

        [Display(Name = "Web Pay Statement ")]
        public bool? PrintStatementInd { get; set; }

        public string SourceDocVerifiedInd { get; set; }

        [Display(Name = "User ID ")]
        public string UserID { get; set; }

        [Display(Name = "Work Email Address")]
        public string  WorkEmail { get; set; }

        [Display(Name = "Personal Email Address")]
        public string PersonalEmail { get; set; }

        [Display(Name = "Email Communication Preference")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "Max length 1")]
        public string EmailPreferenceFlag { get; set; }

        [Display(Name = "Web T4")]
        public bool? WebT4ConsentInd { get; set; }

        [Display(Name = "Benefit Eligibility Date ")]
        public DateTime? BenefitEligibilityDate { get; set; }

        [Display(Name = "Benefit Plan ID")]
        public string BenefitCarrierNumber { get; set; }
    }
}