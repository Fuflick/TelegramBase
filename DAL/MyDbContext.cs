using Domain;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class MyDbContext : DbContext
{
    public DbSet<User> Users{ get; set; } = null!;
    public DbSet<Bot> Bots { get; set; } = null!;
    public DbSet<Command> Commands { get; set; } = null!;
    public DbSet<Channel> Channels { get; set; } = null!;
    public DbSet<BotChat> BotChats { get; set; } = null!;
    public DbSet<UserChat> UserChats { get; set; } = null!;
    public DbSet<BotCommand> BotCommands { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=TelegramDb;Username=postgres;Password=1234"); // ToDo get connection string
    }
}