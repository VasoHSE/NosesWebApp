//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NosesApi.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Operatopn_Doctor
    {
        public int Id { get; set; }
        public Nullable<int> operation_id { get; set; }
        public Nullable<int> doctor_id { get; set; }
        public Nullable<int> rating { get; set; }
    
        public virtual Operation Operation { get; set; }
        public virtual User User { get; set; }
    }
}