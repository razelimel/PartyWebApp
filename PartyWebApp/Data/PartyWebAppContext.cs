using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PartyWebApp.Models;

namespace PartyWebApp.Data
{
    public class PartyWebAppContext : DbContext
    {
        public PartyWebAppContext(DbContextOptions<PartyWebAppContext> options)
    :    base(options)
         {
         }

        public DbSet<Party> Party { get; set; }

        public DbSet<PartyWebApp.Models.Performer> Performer { get; set; }
    }
}
