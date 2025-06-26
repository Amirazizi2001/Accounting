using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities
{
    public class AccountTree:DocumentEntityBase
    {
        public ICollection<Account> Accounts { get; set; }
    }
}
