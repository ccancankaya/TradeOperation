using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class PersonelExpense : IEntity
    {
        public int Id { get; set; }
        public int PersonelId { get; set; }
        public decimal Salary { get; set; }
        public decimal Insurance { get; set; }
        public decimal Food { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
