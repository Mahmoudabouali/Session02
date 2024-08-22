using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02.Model
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public int? DepartmentId { get; set; }
        ////    [ForeignKey("Department")]
        ////public int? DeptId { get; set; }
        //public Department? Department { get; set; }
        //public Department? ManagedDepartment { get; set; }

    }
}
