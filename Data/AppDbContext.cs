using Microsoft.EntityFrameworkCore;

namespace theSite.Data
{
    public class AppDbContext : DbContext //downloaded MS Entity FW to use this base class
    {
        //constructor shortcut = ctor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }
        {
            
        }
    }
}
