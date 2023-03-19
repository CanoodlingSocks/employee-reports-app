using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SQLModels
{
    public class Departments
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; } = string.Empty;
        public Manager Manager { get; set; }
    }
}
