using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SQLModels
{
    public class Managers
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }

        //A manager can manage multiple departments
        public int DepartmentId { get; set; }
        public Departments Departments { get; set; }
    }
}
