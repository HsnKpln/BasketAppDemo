using BasketAppDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace BasketAppDemo.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
