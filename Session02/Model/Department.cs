using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02.Model
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? EmployeeId { get; set; }
        #region one to one
        //[ForeignKey("Maneger")]
        //public int? ManegerId { get; set; }

        ////[ForeignKey("Maneger")]
        ////public int? MGID { get; set; }
        ////[ForeignKey("MGID")]
        //[InverseProperty("ManagedDepartment")]
        //public Employee? Maneger { get; set; } // referance navigational property | relation 
        #endregion
        //[InverseProperty("Department")]
        //public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>(); //collection navigational property
    }
}
//one <=> one
//pk from one class  => fk in theother class

//department <=> employee
//one <=> one
//pk from one => fk in many