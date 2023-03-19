using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SQLModels
{
    public class Employee
    {
        public int Id { get; set; } 
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string JobTitle { get; set; } = string.Empty;
       
        //Unsure if this is needed
        //public int DepartmentId { get; set; }

        //An employee can only belong to ONE department
        public Departments Department { get; set; }
    }
}
