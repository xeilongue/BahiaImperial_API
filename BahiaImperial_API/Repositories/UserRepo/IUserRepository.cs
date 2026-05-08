using BahiaImperial_API.Models;

namespace BahiaImperial_API.Repositories.UserRepo
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> ListarTodos();
        Task Adicionar(User user);
    }
}
