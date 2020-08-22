using System;
using System.Collections.Generic;
using System.Text;

namespace Course_POO_Heranca.Entities
{
    class SavingsAccountPlus : SavingsAccount
    {

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
