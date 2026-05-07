using BahiaImperial_API.Data;
using BahiaImperial_API.Models;
using Microsoft.EntityFrameworkCore;

namespace BahiaImperial_API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> ListarTodos()
        {
            return await _context.users.ToListAsync();
        }

        public async Task Adicionar(User user)
        {
            await _context.users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}
