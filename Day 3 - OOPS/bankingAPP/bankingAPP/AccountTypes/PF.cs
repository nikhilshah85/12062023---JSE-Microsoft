using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAPP.AccountTypes
{
    internal class PF : Accounts
    {
        static int auto_PFAccountNo = 2100;
        public PF(string p_name, string p_type, double p_balance) : base(p_name, p_type, p_balance)
        {
            auto_PFAccountNo = auto_PFAccountNo + 1;
            AccountNo = auto_PFAccountNo;
        }

        public override double Widraw(int p_widrawamount)
        {
            if (p_widrawamount > (AccountBalance * 0.3))
            {
                Console.WriteLine("You can widraw max 30% of " + AccountBalance);
            }
            return base.Widraw(p_widrawamount);
        }
    }
}
