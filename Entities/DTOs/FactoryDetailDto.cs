using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class FactoryDetailDto:IDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public char Phone { get; set; }
        public string Mail { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
