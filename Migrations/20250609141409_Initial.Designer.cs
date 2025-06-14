﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test2S30964JakubKot.Data;

#nullable disable

namespace Test2S30964JakubKot.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20250609141409_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Test2S30964JakubKot.Models.AvailableProgram", b =>
                {
                    b.Property<int>("AvailableProgramId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AvailableProgramId"));

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProgramId")
                        .HasColumnType("int");

                    b.Property<int>("WashingMachineId")
                        .HasColumnType("int");

                    b.HasKey("AvailableProgramId");

                    b.HasIndex("ProgramId");

                    b.HasIndex("WashingMachineId");

                    b.ToTable("Available_Program");

                    b.HasData(
                        new
                        {
                            AvailableProgramId = 1,
                            Price = 33.40m,
                            ProgramId = 1,
                            WashingMachineId = 1
                        },
                        new
                        {
                            AvailableProgramId = 2,
                            Price = 48.70m,
                            ProgramId = 2,
                            WashingMachineId = 2
                        });
                });

            modelBuilder.Entity("Test2S30964JakubKot.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            FirstName = "John",
                            LastName = "Doe"
                        });
                });

            modelBuilder.Entity("Test2S30964JakubKot.Models.PurchaseHistory", b =>
                {
                    b.Property<int>("AvailableProgramId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.HasKey("AvailableProgramId", "CustomerId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Purchase_History");

                    b.HasData(
                        new
                        {
                            AvailableProgramId = 1,
                            CustomerId = 1,
                            PurchaseDate = new DateTime(2025, 6, 3, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 4
                        },
                        new
                        {
                            AvailableProgramId = 2,
                            CustomerId = 1,
                            PurchaseDate = new DateTime(2025, 6, 4, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Test2S30964JakubKot.Models.WashingMachine", b =>
                {
                    b.Property<int>("WashingMachineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WashingMachineId"));

                    b.Property<decimal>("MaxWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SerialNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("WashingMachineId");

                    b.ToTable("Washing_Machine");

                    b.HasData(
                        new
                        {
                            WashingMachineId = 1,
                            MaxWeight = 32.23m,
                            SerialNumber = "WM2012/S431/12"
                        },
                        new
                        {
                            WashingMachineId = 2,
                            MaxWeight = 52.23m,
                            SerialNumber = "WM2014/S491/28"
                        });
                });

            modelBuilder.Entity("Test2S30964JakubKot.Models.WashingProgram", b =>
                {
                    b.Property<int>("ProgramId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProgramId"));

                    b.Property<int>("DurationMinutes")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TemperatureCelsius")
                        .HasColumnType("int");

                    b.HasKey("ProgramId");

                    b.ToTable("Program");

                    b.HasData(
                        new
                        {
                            ProgramId = 1,
                            DurationMinutes = 69,
                            Name = "Quick wash",
                            TemperatureCelsius = 30
                        },
                        new
                        {
                            ProgramId = 2,
                            DurationMinutes = 143,
                            Name = "Cotton Cycle",
                            TemperatureCelsius = 60
                        },
                        new
                        {
                            ProgramId = 3,
                            DurationMinutes = 90,
                            Name = "Synthetic",
                            TemperatureCelsius = 40
                        });
                });

            modelBuilder.Entity("Test2S30964JakubKot.Models.AvailableProgram", b =>
                {
                    b.HasOne("Test2S30964JakubKot.Models.WashingProgram", "WashingProgram")
                        .WithMany("Programs")
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test2S30964JakubKot.Models.WashingMachine", "WashingMachine")
                        .WithMany("AvailablePrograms")
                        .HasForeignKey("WashingMachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WashingMachine");

                    b.Navigation("WashingProgram");
                });

            modelBuilder.Entity("Test2S30964JakubKot.Models.PurchaseHistory", b =>
                {
                    b.HasOne("Test2S30964JakubKot.Models.AvailableProgram", "AvailableProgram")
                        .WithMany("PurchaseHistories")
                        .HasForeignKey("AvailableProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test2S30964JakubKot.Models.Customer", "Customer")
                        .WithMany("Purchases")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AvailableProgram");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Test2S30964JakubKot.Models.AvailableProgram", b =>
                {
                    b.Navigation("PurchaseHistories");
                });

            modelBuilder.Entity("Test2S30964JakubKot.Models.Customer", b =>
                {
                    b.Navigation("Purchases");
                });

            modelBuilder.Entity("Test2S30964JakubKot.Models.WashingMachine", b =>
                {
                    b.Navigation("AvailablePrograms");
                });

            modelBuilder.Entity("Test2S30964JakubKot.Models.WashingProgram", b =>
                {
                    b.Navigation("Programs");
                });
#pragma warning restore 612, 618
        }
    }
}
