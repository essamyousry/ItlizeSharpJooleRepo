//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Joole.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Property
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Property()
        {
            this.TypeFilters = new HashSet<TypeFilter>();
            this.TechSpecFilters = new HashSet<TechSpecFilter>();
            this.TechSpecs = new HashSet<TechSpec>();
        }
    
        public int PropertyID { get; set; }
        public string PropertyName { get; set; }
        public Nullable<bool> IsType { get; set; }
        public Nullable<bool> IsTechSpec { get; set; }
        public Nullable<bool> IsIndividual { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TypeFilter> TypeFilters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TechSpecFilter> TechSpecFilters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TechSpec> TechSpecs { get; set; }
    }
}
