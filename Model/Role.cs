﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_rab_4_YusupovD.A._BPI_23_02.Model
{
    public class Role
    {
        public int Id { get; set; }
        public string NameRole { get; set; }
        public Role() { }
        public Role(int id, string nameRole)
        {
            this.Id = id;
            this.NameRole = nameRole;
        }

    }
}
