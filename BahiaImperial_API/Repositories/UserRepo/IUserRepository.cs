using BahiaImperial_API.Models;
using Microsoft.EntityFrameworkCore;

namespace BahiaImperial_API.Repositories.UserRepo
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> ListarTodos();
        Task Adicionar(User user);
        Task<User> GetById(String userId);

    }
}
