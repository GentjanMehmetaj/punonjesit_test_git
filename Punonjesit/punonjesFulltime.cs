using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punonjesit
{
    public class punonjesFulltime : BasePunonjes
    {
        public int PageseVjetore { get; set; }


        public override int GetMonthlySalary()
        {
            return this.PageseVjetore / 12;
        }

    }
}
