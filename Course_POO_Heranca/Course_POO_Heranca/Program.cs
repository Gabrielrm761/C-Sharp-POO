using System;
using Course_POO_Heranca.Entities;

namespace Course_POO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            /*Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING

            Account acc1 = bacc; // A herança é uma relação "é um", o BusinessAccount é uma Account, a variavel Account recebe naturalmente qualquer tipo de subclasse dela.
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            //acc2.Loan(100.0); a operação Loan não existe na variavel acc2 porque ela é do tipo Account, é exclusiva de BusinessAccount, mesmo ela tendo sido instanciada como BusinessAccount, o compilador não sabe disso.

            //BusinessAccount acc5 = (BusinessAccount)acc3; Embora o compilador não tenha dado nenhum erro, quando o programa for executado vai dar um erro de exceção dizendo que não é possivel converter um tipo SavingsAccount para BusinessAccount
            if(acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
            */
        }
    }
}
