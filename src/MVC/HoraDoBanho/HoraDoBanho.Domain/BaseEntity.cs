﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraDoBanho.Domain
{
    public abstract class BaseEntity
    {
        [Column("id")]
        public int Id { get; set; }
    }
}
