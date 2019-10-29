namespace SistemaPessoa.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PessoaContext : DbContext
    {

        public PessoaContext()
            : base("name=PessoaContext")
        {
        }


        public virtual DbSet<Pessoa> Pessoas { get; set; }
    }

}