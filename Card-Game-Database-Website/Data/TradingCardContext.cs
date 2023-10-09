using Card_Game_Database_Website.Models;
using Microsoft.EntityFrameworkCore;
namespace Card_Game_Database_Website.Data
{
    public class TradingCardContext : DbContext
    {
        public TradingCardContext(DbContextOptions<TradingCardContext> options) : base(options)
        {

        }

        public DbSet<Card> Cards { get; set; }
    }
}
