using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities
{
    public class FiscalYear:DocumentEntityBase
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Entry Entry { get; set; }
        public Ledger Ledger { get; set; }
    }
}
