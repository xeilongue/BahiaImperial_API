using BahiaImperial_API.Models;

namespace BahiaImperial_API.Repositories.TransactionRepo
{
    public interface ITransactionRepository
    {
        Task<IEnumerable<Transaction>> ListarTodos();
        Task Adicionar(Transaction transaction);
    }
}
