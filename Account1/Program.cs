using System;

namespace Account1 {

    public class Program {

        static void Main(string[] args) {

            Account acct1 = new Account();
            acct1.Deposit (1000);
            acct1.Withdraw(350);
            acct1.Debug();
            acct1.Deposit(200);
            acct1.Debug();
                
        }
    }
}
