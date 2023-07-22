using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Project
{
    class Employee
    {
        public int Id { get; set; }
        public string Name{ get; set; }

        public int DepartmentID { get; set; }
        public Department Department { get; set; }
        public Attendance Attendance { get; set; }
    }
}
