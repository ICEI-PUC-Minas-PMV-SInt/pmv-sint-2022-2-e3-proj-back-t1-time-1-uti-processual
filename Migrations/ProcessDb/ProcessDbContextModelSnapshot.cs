﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using utip_backend.Data;

#nullable disable

namespace utip_backend.Migrations.ProcessDb
{
    [DbContext(typeof(ProcessDbContext))]
    partial class ProcessDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("utip_backend.Models.ProcessModel", b =>
                {
                    b.Property<int>("ProcessID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProcessID"), 1L, 1);

                    b.Property<string>("Attorney")
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime()");

                    b.Property<DateTime?>("DataDoCrime")
                        .HasColumnType("datetime()");

                    b.Property<DateTime?>("DataNascReu")
                        .HasColumnType("datetime()");

                    b.Property<string>("DefAddress")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Defendant")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("DefensoriaPublica")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FiliacaoReu")
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("IdStatus")
                        .HasColumnType("int");

                    b.Property<string>("LocalDoCrime")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NaturalidadeReu")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NumInqueritoPolicial")
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("NumLegalProcess")
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("NumeroREDS")
                        .HasColumnType("nvarchar(11)");

                    b.Property<int?>("ProcessTimeCounter")
                        .HasColumnType("int");

                    b.Property<string>("TelefoneReu")
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("TipoPenal")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("TxStatus")
                        .HasColumnType("nvarchar(4)");

                    b.HasKey("ProcessID");

                    b.ToTable("Processo");
                });
#pragma warning restore 612, 618
        }
    }
}
