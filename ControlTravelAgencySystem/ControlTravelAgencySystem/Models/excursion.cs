//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControlTravelAgencySystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class excursion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public excursion()
        {
            this.excursion_order = new HashSet<excursion_order>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public int cost { get; set; }
        public string description { get; set; }
        public Nullable<System.TimeSpan> starting_time { get; set; }
        public int duration { get; set; }
        public Nullable<int> city_id { get; set; }
    
        public virtual city city { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<excursion_order> excursion_order { get; set; }
    }
}
