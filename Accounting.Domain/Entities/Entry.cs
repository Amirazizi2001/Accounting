using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities
{
    public class Entry:DocumentEntityBase
    {
        //شناسه یکتا 
        public int Code { get; set; }
        //توضیحات
        public string Description { get; set; }
        //مقدار بدهکار
        public decimal DebitAmount { get; set; }
        //مقدار بستانکار
        public decimal CreditAmount { get; set; }
        public int LegerId { get; set; }
        public Ledger Ledger { get; set; }
        public int FiscalYearId { get; set; }
        public FiscalYear FiscalYear { get; set; }
        //رابطه با entry items
        public ICollection<EntryItem> EntryItems { get; set; }

    }
}
