using BahiaImperial_API.Models;

namespace BahiaImperial_API.Repositories.TransactionRepo
{
    public interface ITransactionRepository
    {
        Task<IEnumerable<BankTransaction>> ListarTodos();
        Task Adicionar(BankTransaction transaction);
    }
}
