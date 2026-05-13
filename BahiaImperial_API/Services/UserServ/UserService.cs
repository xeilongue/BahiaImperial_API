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
            var user = new User
            {
                Cpf_Cnpj = userDTO.Cpf_Cnpj,
                Password = userDTO.Password,
            };

            await _repository.Adicionar(user);
        }

        public async Task<UserDTO> GetById(String userId)
        {
            User user = await _repository.GetById(userId);

            if (user != null)
            {
                UserDTO userDTO = new UserDTO
                {
                    Cpf_Cnpj = user.Cpf_Cnpj,
                    Password = user.Password
                };
                return userDTO;
            }

            else throw new Exception("Usuário não encontrado");
        }
    }
}
