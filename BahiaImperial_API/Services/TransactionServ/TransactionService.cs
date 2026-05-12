using BahiaImperial_API.DTOs;
using BahiaImperial_API.Models;
using BahiaImperial_API.Repositories.TransactionRepo;
using System;
using System.Collections.Generic;
using System.Text;

namespace BahiaImperial_API.Services.TransactionServ
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _repository;

        public TransactionService(ITransactionRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<BankTransaction>> ListarTodos() =>
            await _repository.ListarTodos();

        public async Task Criar(TransactionDTO transactionDTO)
        {
            var transaction = new BankTransaction
            {
                Type = transactionDTO.Type,
                Amount = transactionDTO.Amount,
            };

            await _repository.Adicionar(transaction);
        }
    }
}
