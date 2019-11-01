using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FirstCoreWebApi.Model
{
    public class FirstCoreContext : DbContext
    {
        public FirstCoreContext(DbContextOptions<FirstCoreContext> options)
            : base(options)
        { 
        }
        public DbSet<Carro> Carros { get; set; }    
    }
}
