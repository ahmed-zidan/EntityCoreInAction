using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Project
{
    class Department
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public bool Deleted { get; set; }
        public ICollection<Employee> employees { set; get; }
        public Branch Branch{ get; set; }
    }
}
