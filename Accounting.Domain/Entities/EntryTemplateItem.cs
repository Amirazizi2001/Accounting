using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities
{
    public class EntryTemplateItem:DocumentEntityBase
    {
        public Account account { get; set; }
        public decimal Amount { get; set; }
        public int TemplateId { get; set; }

    }
}
