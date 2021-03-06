﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeoplePro.Models;

namespace PeoplePro.Models
{
    public class PeopleProContext : DbContext
    {
        public PeopleProContext (DbContextOptions<PeopleProContext> options)
            : base(options)
        {
        }

        public DbSet<PeoplePro.Models.Employee> Employee { get; set; }

        public DbSet<PeoplePro.Models.Building> Building { get; set; }

        public DbSet<PeoplePro.Models.Department> Department { get; set; }
    }
}
