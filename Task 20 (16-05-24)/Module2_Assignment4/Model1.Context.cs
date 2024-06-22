﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Module2_Assignment4
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class practiceEntities : DbContext
    {
        public practiceEntities()
            : base("name=practiceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        [DbFunction("practiceEntities", "fn_getAllEmployee")]
        public virtual IQueryable<fn_getAllEmployee_Result> fn_getAllEmployee(string dept)
        {
            var deptParameter = dept != null ?
                new ObjectParameter("dept", dept) :
                new ObjectParameter("dept", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_getAllEmployee_Result>("[practiceEntities].[fn_getAllEmployee](@dept)", deptParameter);
        }
    
        [DbFunction("practiceEntities", "fn_getAllTables")]
        public virtual IQueryable<fn_getAllTables_Result> fn_getAllTables()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_getAllTables_Result>("[practiceEntities].[fn_getAllTables]()");
        }
    
        [DbFunction("practiceEntities", "getAllTables")]
        public virtual IQueryable<getAllTables_Result> getAllTables()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<getAllTables_Result>("[practiceEntities].[getAllTables]()");
        }
    
        [DbFunction("practiceEntities", "getEmployeeTableBasedOnDept")]
        public virtual IQueryable<getEmployeeTableBasedOnDept_Result> getEmployeeTableBasedOnDept(string dept, Nullable<int> salary)
        {
            var deptParameter = dept != null ?
                new ObjectParameter("dept", dept) :
                new ObjectParameter("dept", typeof(string));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("salary", salary) :
                new ObjectParameter("salary", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<getEmployeeTableBasedOnDept_Result>("[practiceEntities].[getEmployeeTableBasedOnDept](@dept, @salary)", deptParameter, salaryParameter);
        }
    
        public virtual ObjectResult<employeeDetails_Result> employeeDetails()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<employeeDetails_Result>("employeeDetails");
        }
    
        public virtual ObjectResult<pr_employee_grt_Result> pr_employee_grt(Nullable<int> salary)
        {
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("salary", salary) :
                new ObjectParameter("salary", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pr_employee_grt_Result>("pr_employee_grt", salaryParameter);
        }
    }
}
