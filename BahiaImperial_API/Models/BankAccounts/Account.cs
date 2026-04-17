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

        // ATRIBUTOS
        public int Id { get; set; }
        public type Type { get; set; }
        public double Balance { get; set; }
        public double LoanLimit { get; set; }

        // FOREIGN KEY
        public string Cpf_Cnpj { get; set; }

        // NAVIGATION
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();

    }
}
