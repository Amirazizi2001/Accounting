using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities
{
    public class EntitySoft
    {
        public DateTime CreationDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
    public enum DocumentState
    {
        Created,
        Deleted,
        Modified
    }
}
