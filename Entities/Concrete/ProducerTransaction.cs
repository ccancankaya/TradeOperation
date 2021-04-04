using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.Concrete
{
    public class ProducerTransaction : IEntity
    {
        public int Id { get; set; }
        public int ProducerId { get; set; }
        public int UserId { get; set; }
        public int WarehouseId { get; set; }
        public int TakenHazelNuts { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal GivenAdvance { get; set; }
        public int DepositHazelNuts { get; set; }
        public int Efficiency { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
