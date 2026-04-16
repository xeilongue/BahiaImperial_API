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

        public int Id { get; set; }
        public type Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime tr_date { get; set; }
    }
}
