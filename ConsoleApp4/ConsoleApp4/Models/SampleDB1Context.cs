﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ConsoleApp4.Models
{
    public partial class SampleDB1Context : DbContext
    {
        public SampleDB1Context()
        {
        }

        public SampleDB1Context(DbContextOptions<SampleDB1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Tblsample> Tblsamples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-1K6RAF9S;Initial Catalog=SampleDB1;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Tblsample>(entity =>
            {
                entity.ToTable("tblsample");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Text)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("text");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
