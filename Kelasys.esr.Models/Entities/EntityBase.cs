﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Kelasys.esr.Models.Entities {
    public abstract class EntityBase {
        [Key]
        public int Id { get; set; }
    }
}
