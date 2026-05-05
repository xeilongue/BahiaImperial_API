namespace BahiaImperial_API.Models
{
    public class Transaction
    {
        public enum type
        {
            Deposit = 0,
            LoanRequest = 1,
            LoanRepayment = 2,
            Transfer = 3,
            Withdraw = 4
        }

        // ATRIBUTOS
        public int Id { get; set; }
        public type Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime TrDate { get; set; }

        // FOREIGN KEY
        public int AccountId { get; set; }

        public Transaction (type Type, decimal Amount, int AccountId)
        {
            this.Type = Type;
            this.Amount = Amount;

            this.AccountId = AccountId;
        }
    }
}
