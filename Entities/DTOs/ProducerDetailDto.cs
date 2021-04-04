using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProducerDetailDto:IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Phone { get; set; }
        public string Address { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
