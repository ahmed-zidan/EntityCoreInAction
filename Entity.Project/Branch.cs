using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Project
{
    class Branch
    {
        public int Id { get; set; }
        public string Name{ get; set; }

        public ICollection<Department>Departments { get; set; }
    }
}
