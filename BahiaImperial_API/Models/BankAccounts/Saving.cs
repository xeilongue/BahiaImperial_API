namespace BahiaImperial_API.Models.BankAccounts
{
    public class Saving : Account
    {
        public Saving (decimal LoanLimit, string Cpf_Cnpj) : base (LoanLimit, Cpf_Cnpj) {
            Type = AccountType.saving;
        }
    }
}
