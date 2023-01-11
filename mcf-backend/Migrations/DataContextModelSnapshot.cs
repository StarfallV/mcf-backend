﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mcf_backend.Models;

#nullable disable

namespace mcfbackend.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("mcf_backend.Models.MsStorageLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("location_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StorageLocations");
                });

            modelBuilder.Entity("mcf_backend.Models.TrBpkb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("agreement_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("bpkb_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("bpkb_date_in")
                        .HasColumnType("datetime2");

                    b.Property<string>("bpkb_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("branch_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("faktur_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("faktur_no")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("police_no")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BPKBs");
                });
#pragma warning restore 612, 618
        }
    }
}
