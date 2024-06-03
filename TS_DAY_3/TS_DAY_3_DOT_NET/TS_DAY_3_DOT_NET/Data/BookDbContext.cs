using Microsoft.EntityFrameworkCore;
using System.Data;
using TS_DAY_3_DOT_NET.Models;
namespace TS_DAY_3_DOT_NET.Data
{
    public class BookDbContext : DbContext
    {

        public  BookDbContext (DbContextOptions<BookDbContext> options) : base(options) { }


        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}
