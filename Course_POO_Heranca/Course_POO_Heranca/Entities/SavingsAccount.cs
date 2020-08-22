using System;
using System.Collections.Generic;
using System.Text;

namespace Course_POO_Heranca.Entities
{
    class SavingsAccount : Account //a palavra"sealed" é usada antes do "class" para impedir que a classe seja herdada por uma subclasse.
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

        public sealed override void Withdraw(double amount) // Usando o override, você reimplementa na subclasse a operação existente na superclasse, para dar um comportamento diferente. 
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
        // Usando a palavra sealed em um método já sobrescrito(override), evita que ele seja sobrescrita novamente por uma subclasse

        /* Motivos para utilizar o "sealed"
         * • Segurança: dependendo das regras do negócio, às vezes é desejável
                        garantir que uma classe não seja herdada, ou que um método não
                        seja sobreposto.
                        • Geralmente convém selar métodos sobrepostos, pois sobreposições múltiplas
                        podem ser uma porta de entrada para inconsistências
           • Performance: atributos de tipo de uma classe selada são analisados
                          de forma mais rápida em tempo de execução.
                          • Exemplo clássico: string
         */
    }
}
