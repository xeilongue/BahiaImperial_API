namespace BahiaImperial_API.Models.BankAccounts
{
    public class Account
    {
        public enum type
        {
            business,
            checking,
            saving
        }

        public int Id { get; set; }
        public type Type { get; set; }
        public double Balance { get; set; }
        public double LoanLimit { get; set; }

    }
}
