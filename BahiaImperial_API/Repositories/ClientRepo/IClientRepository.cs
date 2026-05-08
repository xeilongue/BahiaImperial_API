using BahiaImperial_API.Models;

namespace BahiaImperial_API.Repositories.ClientRepo
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> ListarTodos();
        Task Adicionar(Client client);
    }
}
