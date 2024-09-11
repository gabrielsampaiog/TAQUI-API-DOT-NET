using Microsoft.EntityFrameworkCore;

namespace Taqui.Database
{
    public class FIAPDBContext(DbContextOptions<FIAPDBContext> options) : DbContext(options)
    {
        //public DbSet<User> Users { get; set; }


    }
}
