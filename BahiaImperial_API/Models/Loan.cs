namespace BahiaImperial_API.Models
{
    public class Loan
    {
        public enum type
        {
            active,
            paid,
            overdue
        }

        // ATRIBUTOS
        public int Id { get; set; }
        public decimal InitialLoan { get; set; }
        public decimal CurrentLoan { get; set; }
        public type LoanStatus { get; set; }
        public DateTime CreatedAt { get; set; }

        // FOREIGN KEY
        public int AccountId { get; set; }

        public Loan (decimal InitialLoan, int AccountId)
        {
            this.InitialLoan = InitialLoan;
            LoanStatus = type.active;

            this.AccountId = AccountId;
        }
    }
}
