namespace BahiaImperial_API.Models
{
    public class Loan
    {
        public enum Type
        {
            active = 0,
            paid = 1,
            overdue = 2
        }

        // ATRIBUTOS
        public int Id { get; set; }
        public decimal InitialLoan { get; set; }
        public decimal CurrentLoan { get; set; }
        public Type LoanStatus { get; set; }
        public DateTime CreatedAt { get; set; }

        // FOREIGN KEY
        public int AccountId { get; set; }

        public Loan (decimal InitialLoan, int AccountId)
        {
            this.InitialLoan = InitialLoan;
            LoanStatus = Type.active;

            this.AccountId = AccountId;
        }
    }
}
