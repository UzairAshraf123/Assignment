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
    
    public partial class OrgProvince
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrgProvince()
        {
            this.Employees = new HashSet<Employee>();
        }
    
        public int ProvinceId { get; set; }
        public string ProvinceCode { get; set; }
        public Nullable<int> OrgCountryId { get; set; }
        public string Name { get; set; }
        public string Archive { get; set; }
    
        public virtual OrgCountry OrgCountry { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
