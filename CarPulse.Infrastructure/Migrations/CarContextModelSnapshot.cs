﻿// <auto-generated />
using CarPulse.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarPulse.Infrastructure.Migrations
{
    [DbContext(typeof(CarContext))]
    partial class CarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarPulse.Domain.Entities.Announcement", b =>
                {
                    b.Property<int>("AnnouncementID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnnouncementID"));

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.Property<int>("SalesmanID")
                        .HasColumnType("int");

                    b.HasKey("AnnouncementID");

                    b.HasIndex("CarID")
                        .IsUnique();

                    b.HasIndex("SalesmanID");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("CarPulse.Domain.Entities.Car", b =>
                {
                    b.Property<int>("CarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarID"));

                    b.Property<string>("BodyType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Gearbox")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Information")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Production")
                        .HasColumnType("int");

                    b.Property<string>("Situation")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Transmission")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CarID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarPulse.Domain.Entities.Engine", b =>
                {
                    b.Property<int>("EngineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EngineID"));

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.Property<string>("EngineType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<double>("EngineValume")
                        .HasColumnType("float");

                    b.HasKey("EngineID");

                    b.HasIndex("CarID")
                        .IsUnique();

                    b.ToTable("Engines");
                });

            modelBuilder.Entity("CarPulse.Domain.Entities.Mileage", b =>
                {
                    b.Property<int>("MileageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MileageID"));

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.Property<long>("Distance")
                        .HasColumnType("bigint");

                    b.Property<string>("DistanceType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MileageID");

                    b.HasIndex("CarID")
                        .IsUnique();

                    b.ToTable("Mileages");
                });

            modelBuilder.Entity("CarPulse.Domain.Entities.Photo", b =>
                {
                    b.Property<int>("PhotoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhotoID"));

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.Property<string>("PhotoAdress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhotoID");

                    b.HasIndex("CarID");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("CarPulse.Domain.Entities.Price", b =>
                {
                    b.Property<int>("PriceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PriceID"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PriceID");

                    b.HasIndex("CarID")
                        .IsUnique();

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("CarPulse.Domain.Entities.Salesman", b =>
                {
                    b.Property<int>("SalesmanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalesmanID"));

                    b.Property<string>("SalesmanEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalesmanName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("SalesmanPhone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("SalesmanPlace")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("SalesmanID");

                    b.ToTable("Salesmen");
                });

            modelBuilder.Entity("CarPulse.Domain.Entities.Supply", b =>
                {
                    b.Property<int>("SupplyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplyID"));

                    b.Property<string>("AddSupplies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarID")
                        .HasColumnType("int");

                    b.HasKey("SupplyID");

                    b.HasIndex("CarID");

                    b.ToTable("Supplies");
                });

            modelBuilder.Entity("CarPulse.Domain.Entities.Announcement", b =>
                {
                    b.HasOne("CarPulse.Domain.Entities.Car", "Car")
                        .WithOne("Announcement")
                        .HasForeignKey("CarPulse.Domain.Entities.Announcement", "CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarPulse.Domain.Entities.Salesman", "Salesman")
                        .WithMany("Announcements")
                        .HasForeignKey("SalesmanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Salesman");
                });

            modelBuilder.Entity("CarPulse.Domain.Entities.Engine", b =>
                {
                    b.HasOne("CarPulse.Domain.Entities.Car", "Car")
                        .WithOne("Engine")
                        .HasForeignKey("CarPulse.Domain.Entities.Engine", "CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("CarPulse.Domain.Entities.Mileage", b =>
                {
                    b.HasOne("CarPulse.Domain.Entities.Car", "Car")
                        .WithOne("Mileage")
                        .HasForeignKey("CarPulse.Domain.Entities.Mileage", "CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("CarPulse.Domain.Entities.Photo", b =>
                {
                    b.HasOne("CarPulse.Domain.Entities.Car", "Car")
                        .WithMany("Photos")
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("CarPulse.Domain.Entities.Price", b =>
                {
                    b.HasOne("CarPulse.Domain.Entities.Car", "Car")
                        .WithOne("Price")
                        .HasForeignKey("CarPulse.Domain.Entities.Price", "CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("CarPulse.Domain.Entities.Supply", b =>
                {
                    b.HasOne("CarPulse.Domain.Entities.Car", "Car")
                        .WithMany("Supplies")
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("CarPulse.Domain.Entities.Car", b =>
                {
                    b.Navigation("Announcement")
                        .IsRequired();

                    b.Navigation("Engine")
                        .IsRequired();

                    b.Navigation("Mileage")
                        .IsRequired();

                    b.Navigation("Photos");

                    b.Navigation("Price")
                        .IsRequired();

                    b.Navigation("Supplies");
                });

            modelBuilder.Entity("CarPulse.Domain.Entities.Salesman", b =>
                {
                    b.Navigation("Announcements");
                });
#pragma warning restore 612, 618
        }
    }
}
