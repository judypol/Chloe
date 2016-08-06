﻿using Chloe.Entity;
using Chloe.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChloeDemo
{
    public enum Gender
    {
        Man = 1,
        Woman
    }

    [TableAttribute("Users")]
    public class User
    {
        [Column(IsPrimaryKey = true)]
        [AutoIncrementAttribute]
        public int Id { get; set; }

        public string Name { get; set; }

        public Gender? Gender { get; set; }

        public int? Age { get; set; }

        public DateTime? OpTime { get; set; }
    }
}
