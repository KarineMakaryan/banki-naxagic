using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Deposit
    {
        private const int percent = 12;
        private int month;
        private int dealMoney = 0;
 

        public Deposit(Bank myBank, Customer cst)
        {
            if (cst.GivingMoney >= 100)
            {
             
                cst.Money -= cst.GivingMoney;
                myBank.Money += cst.GivingMoney;
                dealMoney = cst.GivingMoney;
            }
        }
        public int DealMoney
        {
            get
            {
                return this.dealMoney;
            }
            set
            {
                this.dealMoney = value;
               
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
               
            }
        }


        public void TakeYourDeposit(Bank myBank, Customer cst)
        {
            dealMoney +=(int) month * (dealMoney * percent) / 100;
            myBank.Money -= dealMoney;
            cst.Money += dealMoney;
        }
    }
}
