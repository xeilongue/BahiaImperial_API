namespace BahiaImperial_API.DTOs
{
    public class TransactionDTO
    {
        public enum TransactionType
        {
            Deposit = 0,
            LoanRequest = 1,
            LoanRepayment = 2,
            Transfer = 3,
            Withdraw = 4
        }

        // ATRIBUTOS
        public int Id { get; set; }
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime TrDate { get; set; }
    }
}
