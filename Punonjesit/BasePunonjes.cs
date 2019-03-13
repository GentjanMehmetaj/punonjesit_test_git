using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punonjesit
{
    public abstract class BasePunonjes
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFulName()
        {
            return this.FirstName+"    "+LastName;
            
        }
        public abstract int GetMonthlySalary();
    }  
}
