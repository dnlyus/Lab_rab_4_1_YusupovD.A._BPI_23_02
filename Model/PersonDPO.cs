﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_rab_4_YusupovD.A._BPI_23_02.Model
{
    public class PersonDPO
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public PersonDPO() { }

        public PersonDPO(int id, string role, string firstName, string lastName, DateTime birthday)
        {
            this.Id = id;
            this.Role = role;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthday = birthday;
        }
    }
}
