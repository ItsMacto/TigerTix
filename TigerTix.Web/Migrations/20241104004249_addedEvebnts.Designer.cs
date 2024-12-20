﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TigerTix.Web.Data;

#nullable disable

namespace TigerTix.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241104004249_addedEvebnts")]
    partial class addedEvebnts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TigerTix.Web.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AvailableTickets")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organizer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvailableTickets = 150,
                            Category = "Music",
                            Date = new DateTime(2024, 11, 18, 19, 42, 49, 765, DateTimeKind.Local).AddTicks(6760),
                            Description = "Experience an electrifying night with top rock bands.",
                            ImageUrl = "/images/rock-concert.jpg",
                            Location = "Madison Square Garden",
                            Name = "Rock Concert",
                            Organizer = "Live Nation",
                            Price = 75.00m
                        },
                        new
                        {
                            Id = 2,
                            AvailableTickets = 300,
                            Category = "Exhibition",
                            Date = new DateTime(2024, 12, 3, 19, 42, 49, 765, DateTimeKind.Local).AddTicks(6790),
                            Description = "Discover contemporary art from around the world.",
                            ImageUrl = "/images/art-expo.jpg",
                            Location = "Art Gallery of Ontario",
                            Name = "Art Expo",
                            Organizer = "Art World",
                            Price = 20.00m
                        });
                });

            modelBuilder.Entity("TigerTix.Web.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
