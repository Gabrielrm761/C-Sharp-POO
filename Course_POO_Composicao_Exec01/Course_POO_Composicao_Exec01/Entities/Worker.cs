using System;
using System.Collections.Generic;
using System.Text;
using Course_POO_Composicao_Exec01.Entities.Enums;

namespace Course_POO_Composicao_Exec01.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Deparment{ get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // O worker pode ter vários contratos, por isso deve ser feito uma List.

        public Worker()
        {

        }
        //Não se deve incluir as associações "para muitos", nesse caso, os contratos. Não é usual passar uma lista instaciada no construtor de objetos, a lista vai começar vazia.
        public Worker(string name, WorkerLevel level, double baseSalary, Department deparment)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Deparment = deparment;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
