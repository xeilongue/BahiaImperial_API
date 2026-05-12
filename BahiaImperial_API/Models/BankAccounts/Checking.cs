namespace BahiaImperial_API.Models.BankAccounts
{
    public class Checking : Account
    {
        public Checking()
        {
            Type = AccountType.checking;
        }
    }
}
