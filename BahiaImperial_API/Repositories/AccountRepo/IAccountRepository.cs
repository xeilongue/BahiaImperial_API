using BahiaImperial_API.Models.BankAccounts;

namespace BahiaImperial_API.Repositories.AccountRepo
{
    public interface IAccountRepository
    {
        Task<IEnumerable<Account>> ListarTodos();
        Task Adicionar(Account accounts);
    }
}