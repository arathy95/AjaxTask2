//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _14Sept2019SirTask.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_State
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_State()
        {
            this.tbl_City = new HashSet<tbl_City>();
        }
    
        public int stateid { get; set; }
        public string statename { get; set; }
        public Nullable<int> FKcountryid { get; set; }
    
        public virtual tbl_Country tbl_Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_City> tbl_City { get; set; }
    }
}