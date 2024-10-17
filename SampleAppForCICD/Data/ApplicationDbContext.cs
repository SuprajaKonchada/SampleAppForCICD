﻿using Microsoft.EntityFrameworkCore;
using SampleAppForCICD.Models;

namespace SampleAppForCICD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
