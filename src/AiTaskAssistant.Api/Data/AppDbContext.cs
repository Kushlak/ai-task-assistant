using AiTaskAssistant.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace AiTaskAssistant.Api.Data;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<TaskItem> Tasks => Set<TaskItem>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var task = modelBuilder.Entity<TaskItem>();

        task.HasKey(x => x.Id);

        task.Property(x => x.Title)
            .IsRequired()
            .HasMaxLength(200);

        task.Property(x => x.Description)
            .HasMaxLength(1000);

        task.Property(x => x.Priority)
            .IsRequired();

        task.Property(x => x.IsCompleted)
            .IsRequired();

        task.Property(x => x.CreatedAtUtc)
            .IsRequired();

        task.Property(x => x.Notes)
            .HasMaxLength(2000);
    }
}