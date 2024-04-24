using Microsoft.EntityFrameworkCore;

namespace KutuphaneProjesi.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-792A8RT;" +
                                        "Initial Catalog=KutuphaneProjeDB;" +
                                        "Integrated Security=True;" +
                                        "Persist Security Info=False;" +
                                        "Pooling=False;" +
                                        "Multiple Active Result Sets=False;Encrypt=False;" +
                                        "Trust Server Certificate=False;" +
                                        "Command Timeout=0");
        }
        public DbSet<AdminPanelUser>AdminPanelUsers { get; set; }
    }
}
