using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAPP.AccountTypes
{
    internal class Current : Accounts
    {

        static int auto_currentAccountNo = 701;
        public Current(string p_name, string p_type, double p_balance) : base(p_name, p_type, p_balance)
        {
            auto_currentAccountNo = auto_currentAccountNo + 1;
            AccountNo = auto_currentAccountNo;
        }

        public override double Widraw(int p_widrawamount)
        {
            if ( (AccountBalance - p_widrawamount) > -50000)
            {
                Console.WriteLine("Over Facility Limit exhausted");
            }
            return base.Widraw(p_widrawamount);
        }
    }
}
