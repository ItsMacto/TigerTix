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
    [Migration("20241206232439_AddIsPublishedToEvents2")]
    partial class AddIsPublishedToEvents2
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

                    b.Property<string>("EventType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

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
                            AvailableTickets = 500,
                            Category = "Concert",
                            Date = new DateTime(2025, 1, 5, 18, 24, 39, 751, DateTimeKind.Local).AddTicks(8080),
                            Description = "Experience an unforgettable night with Taylor Swift's iconic hits from all her eras.",
                            EventType = "Concert",
                            ImageUrl = "https://media.newyorker.com/photos/652d4cfca2dd76a04bfbc885/3:4/w_1281,h_1708,c_limit/Brody-Eras-Tour.jpg",
                            IsPublished = false,
                            Location = "SoFi Stadium, Los Angeles, CA",
                            Name = "Taylor Swift - The Eras Tour",
                            Organizer = "Live Nation",
                            Price = 150.00m
                        },
                        new
                        {
                            Id = 2,
                            AvailableTickets = 300,
                            Category = "Sports",
                            Date = new DateTime(2024, 12, 21, 18, 24, 39, 751, DateTimeKind.Local).AddTicks(8110),
                            Description = "Catch the action as two legendary NBA teams go head-to-head.",
                            EventType = "Sports",
                            ImageUrl = "https://s.yimg.com/ny/api/res/1.2/ntZ3XGuHy7vENfP_QzxHKg--/YXBwaWQ9aGlnaGxhbmRlcjt3PTY0MDtoPTQ1MA--/https://media.zenfs.com/en/hoops_hype_usa_today_sports_articles_974/fe1e67ea89571d4532c900e622786b6f",
                            IsPublished = false,
                            Location = "Crypto.com Arena, Los Angeles, CA",
                            Name = "Los Angeles Lakers vs. Boston Celtics",
                            Organizer = "NBA",
                            Price = 120.00m
                        },
                        new
                        {
                            Id = 3,
                            AvailableTickets = 450,
                            Category = "Concert",
                            Date = new DateTime(2025, 1, 15, 18, 24, 39, 751, DateTimeKind.Local).AddTicks(8120),
                            Description = "Join Coldplay for an incredible evening of music and visual spectacle.",
                            EventType = "Concert",
                            ImageUrl = "https://plsn.com/site/wp-content/uploads/1_COLDPLAY-12-©-Steve-Jennings.jpg",
                            IsPublished = false,
                            Location = "MetLife Stadium, East Rutherford, NJ",
                            Name = "Coldplay - Music of the Spheres World Tour",
                            Organizer = "Live Nation",
                            Price = 180.00m
                        },
                        new
                        {
                            Id = 4,
                            AvailableTickets = 350,
                            Category = "Sports",
                            Date = new DateTime(2024, 12, 31, 18, 24, 39, 751, DateTimeKind.Local).AddTicks(8120),
                            Description = "Historic NFL rivalry game between the Packers and the Bears.",
                            EventType = "Sports",
                            ImageUrl = "https://packerswire.usatoday.com/wp-content/uploads/sites/57/2019/09/gettyimages-1172622091-e1568073746100.jpg?w=1000&h=600&crop=1",
                            IsPublished = false,
                            Location = "Lambeau Field, Green Bay, WI",
                            Name = "Green Bay Packers vs. Chicago Bears",
                            Organizer = "NFL",
                            Price = 95.00m
                        },
                        new
                        {
                            Id = 5,
                            AvailableTickets = 400,
                            Category = "Concert",
                            Date = new DateTime(2024, 12, 26, 18, 24, 39, 751, DateTimeKind.Local).AddTicks(8120),
                            Description = "Ed Sheeran brings his latest hits and fan favorites to a city near you.",
                            EventType = "Concert",
                            ImageUrl = "https://surgfm.com/wp-content/uploads/2023/03/ed-sheeran-1.webp",
                            IsPublished = false,
                            Location = "Allegiant Stadium, Las Vegas, NV",
                            Name = "Ed Sheeran - Mathematics Tour",
                            Organizer = "Live Nation",
                            Price = 130.00m
                        },
                        new
                        {
                            Id = 6,
                            AvailableTickets = 250,
                            Category = "Sports",
                            Date = new DateTime(2024, 12, 16, 18, 24, 39, 751, DateTimeKind.Local).AddTicks(8120),
                            Description = "MLB showdown between the Yankees and the Red Sox at the iconic Yankee Stadium.",
                            EventType = "Sports",
                            ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fseatgeek.com%2Fyankees-red-sox-tickets&psig=AOvVaw3CNpQQifM862SFlYfhF76O&ust=1730771043013000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCLj2k9vGwYkDFQAAAAAdAAAAABAE",
                            IsPublished = false,
                            Location = "Yankee Stadium, Bronx, NY",
                            Name = "New York Yankees vs. Boston Red Sox",
                            Organizer = "MLB",
                            Price = 85.00m
                        },
                        new
                        {
                            Id = 7,
                            AvailableTickets = 550,
                            Category = "Concert",
                            Date = new DateTime(2025, 1, 10, 18, 24, 39, 751, DateTimeKind.Local).AddTicks(8130),
                            Description = "Join BTS for a groundbreaking concert experience filled with energy and fan-favorite tracks.",
                            EventType = "Concert",
                            ImageUrl = "https://static.wikia.nocookie.net/the-bangtan-boys/images/4/43/BTS_Map_of_the_Soul_Tour.jpeg/revision/latest?cb=20200122062646",
                            IsPublished = false,
                            Location = "Wembley Stadium, London, UK",
                            Name = "BTS - Map of the Soul Tour",
                            Organizer = "Big Hit Music",
                            Price = 175.00m
                        },
                        new
                        {
                            Id = 8,
                            AvailableTickets = 400,
                            Category = "Sports",
                            Date = new DateTime(2024, 12, 28, 18, 24, 39, 751, DateTimeKind.Local).AddTicks(8130),
                            Description = "NFC East rivals face off in an intense game at AT&T Stadium.",
                            EventType = "Sports",
                            ImageUrl = "https://static.clubs.nfl.com/image/upload/t_editorial_landscape_12_desktop/cowboys/qrozabo6cfsguc3bexop",
                            IsPublished = false,
                            Location = "AT&T Stadium, Arlington, TX",
                            Name = "Dallas Cowboys vs. Philadelphia Eagles",
                            Organizer = "NFL",
                            Price = 100.00m
                        });
                });

            modelBuilder.Entity("TigerTix.Web.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CUID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsStudentAccount")
                        .HasColumnType("bit");

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
