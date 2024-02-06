using Microsoft.EntityFrameworkCore;
using RINHABACKEND.Model;

namespace RINHABACKEND.Data
{
    public class Databasecontext : DbContext
    {   
        public Databasecontext(DbContextOptions<Databasecontext> options) : base(options) { }
        public DbSet<Saldo> Saldos { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }

    

    }
}
