using Microsoft.EntityFrameworkCore;
using PAC.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAC.DataAccess
{
    public class PACContext : DbContext
    { 
        public PACContext() { }
        public PACContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Student>? Student { get; set; }
    }
}
