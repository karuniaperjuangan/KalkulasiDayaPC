//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSUCalculator
{
    using System;
    using System.Collections.Generic;
    
    public partial class DBCPU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DBCPU()
        {
            this.DBComputer = new HashSet<DBComputer>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> base_clock { get; set; }
        public Nullable<int> TDP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DBComputer> DBComputer { get; set; }
    }
}
