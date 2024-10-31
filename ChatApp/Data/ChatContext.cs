using Microsoft.EntityFrameworkCore;

public class ChatContext : DbContext
{
    public ChatContext(DbContextOptions<ChatContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<ChatMessage> Messages { get; set; }
}
