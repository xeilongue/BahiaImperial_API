using Microsoft.AspNetCore.Mvc;
using BahiaImperial_API.Data;
using BahiaImperial_API.Models;

namespace BahiaImperial_API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public ClientsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddClients(Clients clients)
        {
            _appDbContext.Clients.Add(clients);
            await _appDbContext.SaveChangesAsync();

            return Ok(clients);
        }
    }
}
