using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MachineService.Models;

namespace MachineService.Data
{
    public class MachineServiceContext : DbContext
    {
        public MachineServiceContext (DbContextOptions<MachineServiceContext> options)
            : base(options)
        {
        }

        public DbSet<MachineService.Models.Machine> Machine { get; set; }

        public DbSet<MachineService.Models.Service> Service { get; set; }
    }
}
