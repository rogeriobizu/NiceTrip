﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NiceTrip.Models;

namespace NiceTrip.Models
{
    public class Contexto:DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}