using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace p2_renshu_exe_2_1_2.Models;

public partial class MenuContext : DbContext
{
    public MenuContext()
    {
    }

    public MenuContext(DbContextOptions<MenuContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Menu> Menus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wwwht\\source\\repos\\p2_renshu_exe_2_1_2\\p2_renshu_exe_2_1_2\\OICCafe.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.MenuId).HasName("PK__Menu__C99ED230896647A4");

            entity.ToTable("Menu");

            entity.Property(e => e.MenuName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
