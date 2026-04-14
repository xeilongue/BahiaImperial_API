using System.ComponentModel.DataAnnotations;

namespace BahiaImperial_API.Models
{
    public class Clients
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal MonthlyIncome { get; set; }
    }
}
