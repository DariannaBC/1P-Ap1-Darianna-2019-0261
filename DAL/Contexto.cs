using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1P_Ap1_Darianna_2019_0261.Entidades;
using Microsoft.EntityFrameworkCore;

namespace _1P_Ap1_Darianna_2019_0261.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Aportes> Aportes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"data source = Data\aportescontrol.db");
        }
    }
}
