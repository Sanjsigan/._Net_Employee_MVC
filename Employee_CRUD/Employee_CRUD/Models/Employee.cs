using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_CRUD.Models
{
    public class Employee
    {
        [Key] 
        public int EmployeeId { get; set; }
     
        [Required]
        public string FullName { get; set; }


        public string EmpCode { get; set; }

       
        public string Position { get; set; }

     
        public string OfficeLocation { get; set; }
    }
}
