using _2010218103_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2010218103_PER
{
    public class PaqueteTurísticoDbContext : DbContext
    {
        public DbSet<Paquete> Paquetes { get; set; }

        public PaqueteTurísticoDbContext():base ("PaqueteTurístico")
        {

        }
    }
}
