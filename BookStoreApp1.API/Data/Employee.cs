using System;
using System.Collections.Generic;

namespace BookStoreApp1.API.Data
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public int DepId { get; set; }
        public int Salary { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? MgrEmpId { get; set; }
    }
}
