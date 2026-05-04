namespace BahiaImperial_API.Models.BankAccounts
{
    public class Business : Account
    {
        public Business (decimal LoanLimit, string Cpf_Cnpj) : base (LoanLimit, Cpf_Cnpj) {
            Type = AccountType.business;
        }
    }
}
