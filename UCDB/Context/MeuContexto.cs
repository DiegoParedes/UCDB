using System.Data.Entity;
using UCDB.Models;

namespace UCDB.Context
{
    public class MeuContexto : DbContext
    {
        public MeuContexto() : base() { }

        public DbSet<Pedido> Pedidos { get; set; }
    }
}
