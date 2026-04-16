]namespace BahiaImperial_API.Models
{
    public class Loan
    {
        public enum type
        {
            active,
            paid,
            overdue
        }

        public int Id { get; set; }
        public decimal Initial_Loan { get; set; }
        public decimal Current_Loan { get; set; }
        public type Loan_Status { get; set; }
        public DateTime Created_At { get; set; }
    }
}
