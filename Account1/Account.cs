using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account1 {

    class Account {

        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Balance { get; set; }

        public bool Deposit(decimal Amount) {
            if (Amount <= 0) {
                throw new Exception("Amount must be positive.");                                  
            }
            Balance = Balance + Amount;
            return true;
        }
        public bool Withdraw(decimal Amount) {
            if (Amount <= 0) {
                throw new Exception("Amount must be positive.");
            }
            if (Amount > Balance) {
                throw new Exception("Insuffient Funds!");
            }

            Balance = Balance - Amount;
            return true;
            
        }
        public void Debug() {
            Console.WriteLine($"{Id} | {Description} | has a Balance of {Balance:c}");

        }
    }
}
