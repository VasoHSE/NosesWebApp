//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NosesService
{
    using System;
    using System.Collections.Generic;
    
    public partial class City_User
    {
        public int Id { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<int> city_id { get; set; }
    
        public virtual City City { get; set; }
        public virtual User User { get; set; }
    }
}
