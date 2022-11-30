using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VPIProject;

public partial class RentRoomContext : DbContext
{
    public RentRoomContext()
    {
    }

    public RentRoomContext(DbContextOptions<RentRoomContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Arendator> Arendators { get; set; }

    public virtual DbSet<Arendodatel> Arendodatels { get; set; }

    public virtual DbSet<Dogovor> Dogovors { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-SSS2TI2M;Database=RentRoom;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Arendator>(entity =>
        {
            entity.HasKey(e => e.LoginArendator).HasName("PK__Arendato__CA8B194F4E2BE4A1");

            entity.ToTable("Arendator");

            entity.HasIndex(e => e.MobTelArendator, "UQ__Arendato__916A660CBE990E06").IsUnique();

            entity.Property(e => e.LoginArendator)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MobTelArendator)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.NameArendator)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.PasswordArendator)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SurNameArendator)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Arendodatel>(entity =>
        {
            entity.HasKey(e => e.LoginArendodatel).HasName("PK__Arendoda__628ABEE70769B38E");

            entity.ToTable("Arendodatel");

            entity.HasIndex(e => e.MobTelArendodatel, "UQ__Arendoda__5340006ED4B88C2A").IsUnique();

            entity.Property(e => e.LoginArendodatel)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MobTelArendodatel)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.NameArendodatel)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.PasswordArendodatel)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SurNameArendodatel)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Dogovor>(entity =>
        {
            entity.HasKey(e => e.DogovorId).HasName("PK__Dogovor__7795FDB413633FE0");

            entity.ToTable("Dogovor");

            entity.Property(e => e.DogovorId).HasColumnName("DogovorID");
            entity.Property(e => e.DataEndDogovor).HasColumnType("date");
            entity.Property(e => e.DataStartDogovor).HasColumnType("date");
            entity.Property(e => e.LoginArendator)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LoginArendodatel)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.LoginArendatorNavigation).WithMany(p => p.Dogovors)
                .HasForeignKey(d => d.LoginArendator)
                .HasConstraintName("FK__Dogovor__LoginAr__37A5467C");

            entity.HasOne(d => d.LoginArendodatelNavigation).WithMany(p => p.Dogovors)
                .HasForeignKey(d => d.LoginArendodatel)
                .HasConstraintName("FK__Dogovor__LoginAr__38996AB5");

            entity.HasOne(d => d.NumRoomNavigation).WithMany(p => p.Dogovors)
                .HasForeignKey(d => d.NumRoom)
                .HasConstraintName("FK__Dogovor__NumRoom__36B12243");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.NumRoom).HasName("PK__Room__C2542CD75F8A0D32");

            entity.ToTable("Room");

            entity.Property(e => e.NumRoom).ValueGeneratedNever();
            entity.Property(e => e.AirCondition).HasMaxLength(4);
            entity.Property(e => e.Furniture)
                .HasMaxLength(4)
                .HasDefaultValueSql("('нет')");
            entity.Property(e => e.GeneralSpace).HasColumnName("General_space");
            entity.Property(e => e.MonthPrice).HasColumnType("money");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
