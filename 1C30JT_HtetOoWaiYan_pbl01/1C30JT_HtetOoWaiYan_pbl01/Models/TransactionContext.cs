using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _1C30JT_HtetOoWaiYan_pbl01.Models;

public partial class TransactionContext : DbContext
{
    public TransactionContext()
    {
    }

    public TransactionContext(DbContextOptions<TransactionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Transaction> Transactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\wwwht\\source\\repos\\1C30JT_HtetOoWaiYan_pbl01\\1C30JT_HtetOoWaiYan_pbl01\\MoneyTrackerDB.mdf;Integrated Security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.TransactionId).HasName("PK__Transact__55433A6BE1E51BAD");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Memo).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(10);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
