namespace BahiaImperial_API.Models
{
    public class Transaction
    {
        public enum type
        {
            deposit,
            loan_request,
            loan_repayment,
            transfer,
            withdraw
        }

        // ATRIBUTOS
        public int Id { get; set; }
        public type Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime TrDate { get; set; }

        // FOREIGN KEY
        public int AccountId { get; set; }
    }
}
