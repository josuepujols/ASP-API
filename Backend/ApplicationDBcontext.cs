using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend
{
    public class ApplicationDBcontext : DbContext
    {
        //Creamos un contructor 
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options) : base(options)
        {

        }

        public DbSet<Person> Persona { get; set; }
    }
}
