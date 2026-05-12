using BahiaImperial_API.DTOs;
using BahiaImperial_API.Models;
using BahiaImperial_API.Repositories.UserRepo;

namespace BahiaImperial_API.Services.UserServ
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<User>> ListarTodos() =>
            await _repository.ListarTodos();

        public async Task Criar(UserDTO userDTO)
        {
            //if (userDTO.AnoPublicado > DateTime.Now.Year)
            //    throw new Exception("Não é possivel publicar livros do futuro");

            var user = new User
            {
                Cpf_Cnpj = userDTO.Cpf_Cnpj,
                Password = userDTO.Password,
            };

            await _repository.Adicionar(user);
        }
    }
}
