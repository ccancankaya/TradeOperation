using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.Concrete
{
    public class Warehouse : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int RemainingCapacity { get; set; }
    }
}
