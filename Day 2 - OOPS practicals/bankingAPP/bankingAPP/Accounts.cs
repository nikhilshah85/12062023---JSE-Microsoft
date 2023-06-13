using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingAPP
{
    internal class Accounts
    {
        #region Static 
        static int auto_accountNumber = 0; //static int are by default 0

        #endregion

        #region Variables

        int v_accNo;
        string v_accName;
        string v_accType;
        double v_accBalance;
        bool v_accIsActive;

        #endregion

        #region Properties

        public int AccountNo
        {
            get
            {
                return v_accNo;
            }
            set
            {
                v_accNo = value;
            }
        }

        public string AccountName
        {
            get
            {
                return v_accName;
            }
            set
            {
                v_accName = value;
            }
        }

        public string AccountType
        {
            get
            {
                return v_accType;
            }
            set
            {
                v_accType = value;
            }
        }
        public double AccountBalance
        {
            get
            {
                return v_accBalance;
            }
            set
            {
                v_accBalance = value;
            }
        }

        public bool AccountIsActive
        {
            get
            {
                return v_accIsActive;
            }
            set
            {
                v_accIsActive = value;
            }
        }
        #endregion

        #region Methods
        public double Widraw(int p_widrawamount)
        {

            //do a lot of validation
            AccountBalance = AccountBalance - p_widrawamount;
            return AccountBalance;
        }

        public double Deposit(int p_deposit)
        {
            //do a lot of validation 
            AccountBalance = AccountBalance + p_deposit;
            return AccountBalance;
        }

        #endregion

        #region Constructor

        public Accounts(string p_name, string p_type, double p_balance)
        {
            AccountName = p_name;
            AccountType = p_type;
            AccountBalance = p_balance;

            auto_accountNumber = auto_accountNumber + 1;
            AccountNo = auto_accountNumber;
        }
        #endregion

    }
}
