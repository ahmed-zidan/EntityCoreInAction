using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Entity.Project
{
    class Program
    {
        static void Main(string[] args)
        {
            #region eagar
            var db = new Context();

            var query = (from d in db.departments
                         select d.Name).ToList();
                

            #endregion

        }
    }
}
