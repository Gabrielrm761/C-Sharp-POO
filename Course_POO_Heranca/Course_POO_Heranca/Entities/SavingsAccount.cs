using System;
using System.Collections.Generic;
using System.Text;

namespace Course_POO_Heranca.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount) // Usando o override, você reimplementa na subclasse a operação existente na superclasse, para dar um comportamento diferente. 
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
