using System.ComponentModel.DataAnnotations;

namespace BahiaImperial_API.Models
{
    public class Client
    {

        // ATRIBUTOS
        public string Cpf_Cnpj { get; set; }
        public string Name { get; set; }
        public decimal MonthlyIncome { get; set; }

        public User User { get; set; }

        public Client(string Cpf_Cnpj, string Name, decimal MonthlyIncome, User User)
        {
            this.Cpf_Cnpj = Cpf_Cnpj;
            this.Name = Name;
            this.MonthlyIncome = MonthlyIncome;

            this.User = User;
        }
    }
}