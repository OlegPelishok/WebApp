//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkForAll.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Services
    {
        public Services()
        {
            this.Master_Services = new HashSet<Master_Services>();
        }
    
        public int service_id { get; set; }
        public int category_id { get; set; }
        public string service_name { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<Master_Services> Master_Services { get; set; }
    }
}
