using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisualRoutines.Data
{
    public class ApplicationDbContext:DbContext
    {
            //need to generate the Microsoft.Entity Framework for the DbContext error
   
            //constructor chaining-inject the property into parent class for use in its own constructor
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

            //create database set
            public DbSet<Task> Tasks { get; set; }
        }

    }

