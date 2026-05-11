using BahiaImperial_API.Models;

namespace BahiaImperial_API.Services.UserServ
{
    public interface IUserService
    {
        Task<IEnumerable<User>> ListarTodos();
        //Task Criar()
    }
}
