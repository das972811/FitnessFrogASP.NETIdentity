﻿// <auto-generated />
using System;
using FitnessFrogDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitnessFrogDb.Migrations
{
    [DbContext(typeof(FitnessFrogContext))]
    [Migration("20240207052325_UpdatedActivityAddedEntry")]
    partial class UpdatedActivityAddedEntry
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FitnessFrogDb.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Activity", (string)null);
                });

            modelBuilder.Entity("FitnessFrogDb.Models.Entry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Duration")
                        .HasPrecision(5, 1)
                        .HasColumnType("decimal(5,1)");

                    b.Property<bool>("Exclude")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Intensity")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.ToTable("Entry", (string)null);
                });

            modelBuilder.Entity("FitnessFrogDb.Models.Entry", b =>
                {
                    b.HasOne("FitnessFrogDb.Models.Activity", "Activity")
                        .WithMany("Entries")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");
                });

            modelBuilder.Entity("FitnessFrogDb.Models.Activity", b =>
                {
                    b.Navigation("Entries");
                });
#pragma warning restore 612, 618
        }
    }
}
