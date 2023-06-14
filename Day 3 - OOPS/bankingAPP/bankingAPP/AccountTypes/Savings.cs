using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAPP.AccountTypes
{
    internal class Savings : Accounts
    {

        static int auto_SavingsAccountNo = 501;
        public Savings(string p_name, string p_type, double p_balance):base(p_name,p_type,p_balance)
        {
            auto_SavingsAccountNo = auto_SavingsAccountNo + 1;
            AccountNo = auto_SavingsAccountNo;
        }

        public override double Widraw(int p_widrawamount)
        {
            if (p_widrawamount > 10000)
            {
                //throw new exception
                Console.WriteLine("Savings Account can widraw max 10000");
            }
            return base.Widraw(p_widrawamount);
        }
    }
}
