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
    
    public partial class OrgGender
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrgGender()
        {
            this.Employees = new HashSet<Employee>();
        }
    
        public int GenderId { get; set; }
        public string GenderCode { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string Archive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}