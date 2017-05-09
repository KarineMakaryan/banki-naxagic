using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Loan
    {
        private const int percent = 9;
        private int dealMoney = 0;
        private int month;
       
        public Loan(Bank bk, Customer cst)
        {
            if (cst.Guarantor==1 && cst.Money > 1000)
            {
               
                cst.Money += cst.NeededMoney;
                bk.Money -= cst.NeededMoney;
                dealMoney = cst.NeededMoney;
            }
            else 
            {
                Console.WriteLine("Customer can't take a loan!.");
            }
        }

        public int DealMoney
        {
            get
            {
                return dealMoney;
            }
            set
            {
                dealMoney = value;
            }
        }

        public int Month
        {
            get
            {
                return this.month;
            }
            set
            {
                this.month = value;

                dealMoney += (int)month * (dealMoney * percent) / 100;
            }
        }
        public void ToPayLoan(Bank myBank, Customer cst)
        { 
                cst.Money -= dealMoney;
                myBank.Money += dealMoney;
                Console.WriteLine("Customer paid the loan!");
            
        }

    }
}
