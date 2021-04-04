using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FactoryTransaction : IEntity
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public int FactoryId { get; set; }
        public int WarehouseId { get; set; }
        public int GivenHuzelNuts { get; set; }
        public decimal TakenPrice { get; set; }
        public decimal TakenAdvance { get; set; }
        public int DepositHuzelNuts { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
