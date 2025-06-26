using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities
{
    public class EntryTemplate:DocumentEntityBase
    {
        //توضیحات
        public string Description { get; set; }
        public int FinEventId { get; set; }
        public string Items { get; set; }
    }
}
