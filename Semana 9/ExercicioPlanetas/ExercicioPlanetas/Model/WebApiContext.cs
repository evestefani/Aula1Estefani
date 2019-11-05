using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPlanetas.Model
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options)
            : base(options)
        {

        }
        public DbSet<Objeto> Objetos { get; set; }
    }
}
