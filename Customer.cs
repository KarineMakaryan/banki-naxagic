using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Customer
    {

        private int creditHistory;
        private int guarantor;
        private int money;
        private int neededMoney;
        private int givingMoney;

        public Customer()
        {
            creditHistory = 0;
            guarantor =0;
            money = 0;
        }

        public Customer(int creditHistory1, int guarantor1, int money1)
        {
            this.creditHistory = creditHistory1;
            this.guarantor = guarantor1;
            this.money = money1;
        }

        public int GivingMoney
        {
            get
            {
                return givingMoney;
            }
            set
            {
                givingMoney = value;
            }
        }

        public int NeededMoney
        {
            get
            {
                return this.neededMoney;
            }
            set
            {
                this.neededMoney = value;
            }
        }

        public int Money
        {
            get
            {
                return this.money;
            }
            set
            {
                this.money = value;
            }
        }



        public int CreditHistory
        {
            get
            {
                return this.creditHistory;
            }
            set
            {
                this.creditHistory = value;
            }
        }
        public string History()
        {

            if (this.creditHistory > 0)
            {
                return "Good";
            }
            else
            {
                return "First deal!";
            }
        }

        public int Guarantor
        {
            get
            {
                return this.guarantor;
            }
            set
            {
                this.guarantor = value;
            }
        }
      


    }
}
