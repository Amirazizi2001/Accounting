using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities
{
    public class EntryItem:DocumentEntityBase
    {
        //کد یکتا
        public int Code { get; set; }
        //توضیحات
        public string Description { get; set; }
        //مقدار
        public decimal Amount { get; set; }
        public Entry Entry { get; set; }
    }
}
