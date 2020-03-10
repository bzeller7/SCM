using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCM.Models
{
    public class InfoContext
    {
        public class infoContext : DbContext
        {
            public infoContext(DbContextOptions<InfoContext> options)
                : base(options)
            {

            }

            //Add all Models (classes) as a DbSet that need
            //to be tracked by the database
            public DbSet<Contact> contacts { get; set; }
        }
    }
    }
}
