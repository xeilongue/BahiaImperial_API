using BahiaImperial_API.DTOs;
using BahiaImperial_API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BahiaImperial_API.Services.TransactionServ
{
    public interface ITransactionService
    {
        Task<IEnumerable<BankTransaction>> ListarTodos();
        Task Criar(TransactionDTO transactionDTO);
    }
}
