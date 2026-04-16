using System.ComponentModel.DataAnnotations;

namespace BahiaImperial_API.Models
{
    public class Client
    {
        public string Cpf_Cnpj { get; set; }
        public string Name { get; set; }
        public decimal MonthlyIncome { get; set; }
    }
}
