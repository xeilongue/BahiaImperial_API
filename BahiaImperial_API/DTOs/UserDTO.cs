using System.ComponentModel.DataAnnotations;

namespace BahiaImperial_API.DTOs
{
    public class UserDTO
    {
        public string Cpf_Cnpj { get; set; }
        public string Password { get; set; }
    }
}
