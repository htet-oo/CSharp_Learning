using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace p2_renshu_2_1.Models;

public partial class MemberContext : DbContext
{
    public MemberContext()
    {
    }

    public MemberContext(DbContextOptions<MemberContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Member> Members { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wwwht\\source\\repos\\p2_renshu_2_1\\p2_renshu_2_1\\Database1.mdf;Integrated Security=True\n");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Member>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__Member__0CF04B183A3787A9");

            entity.ToTable("Member");

            entity.Property(e => e.MemberName).HasMaxLength(20);
            entity.Property(e => e.MemberTel).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
