//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProbApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Department
    {
        public Department()
        {
            this.Employees = new HashSet<Employee>();
        }
    
        public int ID_DEPARTMENT { get; set; }
        public string DEPARTMENT_NAME { get; set; }
    
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
