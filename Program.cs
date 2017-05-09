using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            int credithisory = 0;
            int guar = 0;
            int money = 0;
            Console.WriteLine("Do you have  credit history?  (1-yes, 0-no)");
            credithisory = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you have a guarantor? (1-yes, 0-no)");
            guar = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How much money do you have?");
            money = Convert.ToInt32(Console.ReadLine());




            Customer person = new Customer(credithisory, guar, money);

            Console.WriteLine("Customer's credit history is " + person.History() + ".");
            Console.WriteLine("Customer has " + person.Guarantor + " guarantor.");
            Console.WriteLine("Customer has " + person.Money + "$.");

            Bank myBank = new Bank();
            Console.WriteLine("\n" + "There are " + myBank.Money + "$ in the Bank.");

            Console.WriteLine("\n\nTaking a loan : ");
            Console.WriteLine("How much money customer needs to take?");
            person.NeededMoney = Convert.ToInt32(Console.ReadLine());
            if (person.Guarantor != 1 || person.Money < 1000)
                return;


            Loan personLoan = new Loan(myBank, person);
            Console.WriteLine("In how month customer will pay his loan?");
            personLoan.Month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Customer has " + person.Money + " dollars.");
            Console.WriteLine("There are " + myBank.Money + " dollars in the Bank.\n");
            Console.WriteLine("Customer must pay " + personLoan.DealMoney + " dollars.");


            Console.WriteLine("\nCustomer pays his loan : ");
            personLoan.ToPayLoan(myBank, person);



            Console.WriteLine("\n\nGiving a deposit : ");

            Console.WriteLine("How much money does the customer want to give?");
            person.GivingMoney = Convert.ToInt32(Console.ReadLine());
            Deposit personDeposit = new Deposit(myBank, person);
            Console.WriteLine("In how month will the customer take his deposit?");
            personDeposit.Month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Customer has " + person.Money + "$.");
            Console.WriteLine("There are " + myBank.Money + "$ in the Bank.\n");

            Console.WriteLine("\nCustomer takes his money : ");
            personDeposit.TakeYourDeposit(myBank, person);

            Console.WriteLine("Customer has " + person.Money + "$.");
            Console.Write("\n" + "There are " + myBank.Money + "$ in the Bank.");
        }
    }
}
