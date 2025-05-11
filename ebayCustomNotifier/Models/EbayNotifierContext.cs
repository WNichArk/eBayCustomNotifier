using ebayCustomNotifier.Models.Items;
using Microsoft.EntityFrameworkCore;

namespace ebayCustomNotifier.Models
{
    public class EbayNotifierContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public EbayNotifierContext(DbContextOptions<EbayNotifierContext> options) : base(options) { }
    }
}
