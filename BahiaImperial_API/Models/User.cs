using BahiaImperial_API.Models.BankAccounts;

namespace BahiaImperial_API.Models
{
    public class User
    {
        // ATRIBUTOS
        // FOREIGN KEY (CPF_CNPJ)
        public string Cpf_Cnpj { get; set; }
        public string Password { get; set; }

        // NAVIGATION CLIENT
        public Client Client { get; set; }
        // NAVIGATION ACCOUNTS
        public ICollection<Account> Accounts { get; set; } = new List<Account>();

        public User (string Cpf_Cnpj, string Password)
        {
            this.Cpf_Cnpj = Cpf_Cnpj;
            this.Password = Password;
        }
    }
}
