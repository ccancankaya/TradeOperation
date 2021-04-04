﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public char IdentityNumber { get; set; }
        public string Email { get; set; }
        public char Phone { get; set; }
        public string Address { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdatedTime { get; set; }

        //22:05 Dersteyiz
    }
}
