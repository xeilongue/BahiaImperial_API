using BahiaImperial_API.Data;
using BahiaImperial_API.Models;
using Microsoft.EntityFrameworkCore;

namespace BahiaImperial_API.Repositories.TransactionRepo
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly AppDbContext _context;

        public TransactionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BankTransaction>> ListarTodos()
        {
            return await _context.transactions.ToListAsync();
        }

        public async Task Adicionar(BankTransaction transaction)
        {
            await _context.transactions.AddAsync(transaction);
            await _context.SaveChangesAsync();
        }
    }
}
