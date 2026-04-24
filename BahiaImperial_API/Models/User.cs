using BahiaImperial_API.Models.BankAccounts;

namespace BahiaImperial_API.Models
{
    public class User
    {
        // ATRIBUTOS
        // FOREIGN KEY (CPF_CNPJ)
        public string Cpf_Cnpj { get; set; }
        public int Password { get; set; }

        // NAVIGATION CLIENT
        public Client Client { get; set; }
        // NAVIGATION ACCOUNTS
        public ICollection<Account> Accounts { get; set; } = new List<Account>();
    }
}
