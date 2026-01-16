using Microsoft.EntityFrameworkCore;
using TodoJsAspire.ApiService.Models;

public class TodoDbContext(DbContextOptions<TodoDbContext> options) : DbContext(options)
{
    public DbSet<Todo> Todo { get; set; } = default!;
}
