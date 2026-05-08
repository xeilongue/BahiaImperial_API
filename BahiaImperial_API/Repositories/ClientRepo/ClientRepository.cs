using BahiaImperial_API.Data;
using BahiaImperial_API.Models;
using Microsoft.EntityFrameworkCore;

namespace BahiaImperial_API.Repositories.ClientRepo
{
    public class ClientRepository : IClientRepository
    {
        private readonly AppDbContext _context;

        public ClientRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> ListarTodos()
        {
            return await _context.clients.ToListAsync();
        }

        public async Task Adicionar(Client client)
        {
            await _context.clients.AddAsync(client);
            await _context.SaveChangesAsync();
        }
    }
}
