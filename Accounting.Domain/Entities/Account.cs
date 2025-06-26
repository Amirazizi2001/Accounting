using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Domain.Entities
{

    public class Account:DocumentEntityBase
    {
        //نوع حساب
        public AccountType Type { get; set; }
        //دائم است یاموقت یا مخلوط
        public AccountKind Kind  { get; set; }
        //ماهیت حساب
        public AccountNature  Nature { get; set; }
        //سطح حساب
        public AccountLevel Level { get; set; }
        //گردش بدهکار
        public decimal Debit { get; set; }
        //گردش بستانکار
        public decimal Credit { get; set; }
        //کد یکتا
        public int Code { get; set; }
        //رابطه با درخت واره حساب
        public AccountTree AccountTree { get; set; }
        //رابطه درخت واره ای
        public Account? Parent { get; set; }
        public ICollection<Account>? Childern { get; set; }
    }
    public enum AccountType
    {
        Asset,    
        Liability,  
        Equity,
        Revenue,
        Expense
    }
    public enum AccountKind
    {
        Permanent,
        Temoorary,
        Mixed
        
    }
    public enum AccountNature
    {
        Debit,
        Credit,
        Neutral
    }
    public enum AccountLevel
    {
        AccountGroup,
        Total,
        Specific,
        Tafzil

    }
}
