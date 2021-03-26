using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Account samsuzzaman = new Savings("Samsuzzaman", "001", 5000.0f);
            Account tanvir = new Current("Tanvir", "002", 2000f);
            Account zaman = new Fixed("Zaman", "003", 1000f, 2015, 10);

            Account ss = new SuperSavings("Joy", "004", 100f);
            ss.Deposit(80);
            ss.ShowInfo();

            Account overdraft = new Overdraft("Abid", "005", 1000f, 5000);
            overdraft.Transfer(ss, 5000);
            overdraft.Deposit(10000);
            overdraft.ShowInfo();
            overdraft.showAllTransaction();

            Customer customer = new Customer("Samsuzzaman Tanvir");

            tanvir.Deposit(10000);
            tanvir.Transfer(samsuzzaman, 5000);
            tanvir.showAllTransaction();

            samsuzzaman.ShowInfo();
            samsuzzaman.Deposit(2000f);
            samsuzzaman.Transfer(tanvir, 4000);
            samsuzzaman.Withdraw(3000);
            samsuzzaman.showAllTransaction();

            //zaman.Deposit(5000);
            //zaman.Withdraw(1000);
            //zaman.ShowInfo();

            //samsuzzaman.Transfer(tanvir, 1000f);
            //tanvir.ShowInfo();

            //customer.AddAccount(samsuzzaman, tanvir);
            //customer.AccDetails();
        }
    }
}