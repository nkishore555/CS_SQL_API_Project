using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DBContext
{
    public class HositalManagementDbContext: DbContext
    {
        public HositalManagementDbContext(DbContextOptions<HositalManagementDbContext> options) : base(options)
        {


        }

        public DbSet<HotelManagement.Entity.User> Users { get; set; }
    }
}
