﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace PeoplePro.Models
{
    public class Building
    {
        public int Id { get; set; }
    
        public List<Department> Departments;

        public string Name { get; set; } 

        public string Address { get; set; } 
    }
}