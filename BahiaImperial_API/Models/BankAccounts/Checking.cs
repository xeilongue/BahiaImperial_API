namespace BahiaImperial_API.Models.BankAccounts
{
    public class Checking : Account
    {
        public Checking (decimal LoanLimit, string Cpf_Cnpj) : base (LoanLimit, Cpf_Cnpj) {
            Type = AccountType.checking;
        }
    }
}
