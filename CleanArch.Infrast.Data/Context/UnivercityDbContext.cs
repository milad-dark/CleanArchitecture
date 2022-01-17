﻿using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infrast.Data.Context
{
    public class UnivercityDbContext:DbContext
    {
        public UnivercityDbContext(DbContextOptions<UnivercityDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Course> Courses{ get; set; }
    }
}
