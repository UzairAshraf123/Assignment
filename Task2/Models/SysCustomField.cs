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
    
    public partial class SysCustomField
    {
        public int SysCustomFieldsId { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string CustomLabel { get; set; }
        public string VisibleInd { get; set; }
        public int MaxLength { get; set; }
        public string Required { get; set; }
    }
}