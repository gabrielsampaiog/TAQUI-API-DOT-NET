using Microsoft.EntityFrameworkCore;
using Taqui.Models;

namespace Taqui.Database
{
    public class FIAPDBContext(DbContextOptions<FIAPDBContext> options) : DbContext(options)
    {
        public DbSet<Cliente> Clientes { get; set; }


    }
}
