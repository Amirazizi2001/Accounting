using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities
{
    public class Ledger:EntitySoft
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal BalamceChange()
        {
            return Debit - Credit;
        }
        public ICollection<Entry> Entries { get; set; }
        public FiscalYear FiscalYear { get; set; }
    }
}

