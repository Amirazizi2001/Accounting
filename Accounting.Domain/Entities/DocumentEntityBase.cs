using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities
{
    public class DocumentEntityBase:Entity
    {
        public int Name { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
