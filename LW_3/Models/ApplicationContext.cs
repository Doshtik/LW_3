using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LW_3.Models;

public partial class ApplicationContext : DbContext
{
    public ApplicationContext() { }

    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=blog;Username=postgres;Password=1111");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_posts");

            entity.ToTable("posts");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.DateOfPublication).HasColumnName("dateOfPublication");
            entity.Property(e => e.IdOfUser).HasColumnName("idOfUser");
            entity.Property(e => e.Title).HasColumnName("title");

            entity.HasOne(d => d.IdOfUserNavigation).WithMany(p => p.Posts)
                .HasForeignKey(d => d.IdOfUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_posts_users");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_users");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Nickname).HasColumnName("nickname");
            entity.Property(e => e.Phone).HasColumnName("phone");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
