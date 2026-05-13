using Microsoft.AspNetCore.Mvc;
using BahiaImperial_API.Data;
using BahiaImperial_API.Models;
using BahiaImperial_API.DTOs;
using BahiaImperial_API.Repositories.UserRepo;
using BahiaImperial_API.Services.UserServ;
using Microsoft.AspNetCore.Authorization;

namespace BahiaImperial_API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _service.ListarTodos());

        [HttpPost]
        public async Task<IActionResult> Post(UserDTO userDTO)
        {
            try
            {
                await _service.Criar(userDTO);
                return Ok("Usuario cadastrado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}

