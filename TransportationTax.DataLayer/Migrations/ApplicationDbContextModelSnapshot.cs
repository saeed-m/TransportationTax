﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransportationTax.DataLayer.dbcontext;

#nullable disable

namespace TransportationTax.DataLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("TransportationTax.DomainClasses.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CarColor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CarName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CarPlateNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("TransportationTax.DomainClasses.Entities.CongestionTax", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FromTime")
                        .HasColumnType("TEXT");

                    b.Property<double>("TaxAmount")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("ToTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("congestionTaxes");
                });

            modelBuilder.Entity("TransportationTax.DomainClasses.Entities.ExemptVehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("VehicleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("exemptVehicles");
                });

            modelBuilder.Entity("TransportationTax.DomainClasses.Entities.PayToll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PayTollCode")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PayTollDistance")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PayTollName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("payTolls");
                });

            modelBuilder.Entity("TransportationTax.DomainClasses.Entities.TimeExemption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExemptInMinite")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("timeExemptions");
                });
#pragma warning restore 612, 618
        }
    }
}
