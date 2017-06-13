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
    
    public partial class TableDataAccess
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TableDataAccess()
        {
            this.UserElementPermissions = new HashSet<UserElementPermission>();
        }
    
        public int ID { get; set; }
        public Nullable<int> DataAccessID { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string ColumnLabel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserElementPermission> UserElementPermissions { get; set; }
        public virtual OrgDataAccess OrgDataAccess { get; set; }
    }
}
