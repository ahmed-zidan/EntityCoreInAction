using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Project
{
    class Attendance
    {
        public int EmpID { get; set; }
        public DateTime Date{ get; set; }

        public ICollection<Employee>Employees { get; set; }
    }
}
