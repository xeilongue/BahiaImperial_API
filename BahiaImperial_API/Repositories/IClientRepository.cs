using BahiaImperial_API.Models;

namespace BahiaImperial_API.Repositories
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> ListarTodos();
        Task Adicionar(Client client);
    }
}
