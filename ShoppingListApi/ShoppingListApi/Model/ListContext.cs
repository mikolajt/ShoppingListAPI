using Microsoft.EntityFrameworkCore;

namespace ShoppingListApi.Model
{
    public class ListContext : DbContext
    {
        public ListContext(DbContextOptions<ListContext> options) : base(options)
        {

        }

        public DbSet<ListItem> ListItems { get; set; }
    }
}
