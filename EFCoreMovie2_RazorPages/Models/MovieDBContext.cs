using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFCoreMovie2_RazorPages.Models;

public partial class MovieDBContext : DbContext
{
    public MovieDBContext()
    {
    }

    public MovieDBContext(DbContextOptions<MovieDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Studio> Studios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MovieDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Movie__3214EC07316E578E");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Studio).WithMany(p => p.Movies).HasConstraintName("FK_Movie_Studio");
        });

        modelBuilder.Entity<Studio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Studio__3214EC07C4166C13");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
