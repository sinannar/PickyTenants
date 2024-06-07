﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PickyTenants.WebApi;

#nullable disable

namespace PickyTenants.WebApi.Migrations
{
    [DbContext(typeof(PickyTenantsDbContext))]
    [Migration("20240607224515_SecondMigration")]
    partial class SecondMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("PickyTenants.WebApi.Entities.Property", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Lat")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Lng")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("PickyTenants.WebApi.Entities.Review", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("PropertyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TenantName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("PickyTenants.WebApi.Entities.Review", b =>
                {
                    b.HasOne("PickyTenants.WebApi.Entities.Property", "Property")
                        .WithMany("PropertyReviews")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Property");
                });

            modelBuilder.Entity("PickyTenants.WebApi.Entities.Property", b =>
                {
                    b.Navigation("PropertyReviews");
                });
#pragma warning restore 612, 618
        }
    }
}
