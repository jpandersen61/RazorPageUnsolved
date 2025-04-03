﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using EFCoreHotel_RazorPages.Models;

#nullable disable

namespace EFCoreHotel_RazorPages.HotelDBContext
{
    public partial class HoteldbContext : DbContext
    {
        public HoteldbContext()
        {
        }
        public HoteldbContext(DbContextOptions<HoteldbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Guest> Guests { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasOne(d => d.GuestNoNavigation)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.GuestNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Booking__Guest_N__2D27B809");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => new { d.RoomNo, d.HotelNo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Booking__2E1BDC42");
            });

            modelBuilder.Entity<Guest>(entity =>
            {
                entity.HasKey(e => e.GuestNo)
                    .HasName("PK__Guest__CB8B32A0281734E2");

                entity.Property(e => e.GuestNo).ValueGeneratedNever();

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.HasKey(e => e.HotelNo)
                    .HasName("PK__Hotel__AA4F173E03D4B256");

                entity.Property(e => e.HotelNo).ValueGeneratedNever();

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => new { e.RoomNo, e.HotelNo })
                    .HasName("PK__Room__E34B708F606BBAAB");

                entity.Property(e => e.Types)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')")
                    .IsFixedLength(true);

                entity.HasOne(d => d.HotelNoNavigation)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.HotelNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Room__Hotel_No__286302EC");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}