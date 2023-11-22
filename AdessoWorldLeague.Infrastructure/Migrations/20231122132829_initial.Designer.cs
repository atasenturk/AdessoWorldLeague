﻿// <auto-generated />
using System;
using AdessoWorldLeague.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdessoWorldLeague.Infrastructure.Migrations
{
    [DbContext(typeof(AdessoDbContext))]
    [Migration("20231122132829_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AdessoWorldLeauge.Domain.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Türkiye"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Almanya"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fransa"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Hollanda"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Portekiz"
                        },
                        new
                        {
                            Id = 6,
                            Name = "İtalya"
                        },
                        new
                        {
                            Id = 7,
                            Name = "İspanya"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Belçika"
                        });
                });

            modelBuilder.Entity("AdessoWorldLeauge.Domain.Entities.Draw", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("drawDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("drawerFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("drawerLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Draws", (string)null);
                });

            modelBuilder.Entity("AdessoWorldLeauge.Domain.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("DrawId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DrawId")
                        .IsUnique()
                        .HasFilter("[DrawId] IS NOT NULL");

                    b.ToTable("Groups", (string)null);
                });

            modelBuilder.Entity("AdessoWorldLeauge.Domain.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("GroupId");

                    b.ToTable("Teams", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Adesso İstanbul"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            Name = "Adesso Ankara"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 1,
                            Name = "Adesso İzmir"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 1,
                            Name = "Adesso Antalya"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 2,
                            Name = "Adesso Berlin"
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 2,
                            Name = "Adesso Frankfurt"
                        },
                        new
                        {
                            Id = 7,
                            CountryId = 2,
                            Name = "Adesso Münih"
                        },
                        new
                        {
                            Id = 8,
                            CountryId = 2,
                            Name = "Adesso Dortmund"
                        },
                        new
                        {
                            Id = 9,
                            CountryId = 3,
                            Name = "Adesso Paris"
                        },
                        new
                        {
                            Id = 10,
                            CountryId = 3,
                            Name = "Adesso Marsilya"
                        },
                        new
                        {
                            Id = 11,
                            CountryId = 3,
                            Name = "Adesso Nice"
                        },
                        new
                        {
                            Id = 12,
                            CountryId = 3,
                            Name = "Adesso Lyon"
                        },
                        new
                        {
                            Id = 13,
                            CountryId = 4,
                            Name = "Adesso Amsterdam"
                        },
                        new
                        {
                            Id = 14,
                            CountryId = 4,
                            Name = "Adesso Rotterdam"
                        },
                        new
                        {
                            Id = 15,
                            CountryId = 4,
                            Name = "Adesso Lahey"
                        },
                        new
                        {
                            Id = 16,
                            CountryId = 4,
                            Name = "Adesso Eindhoven"
                        },
                        new
                        {
                            Id = 17,
                            CountryId = 5,
                            Name = "Adesso Lisbon"
                        },
                        new
                        {
                            Id = 18,
                            CountryId = 5,
                            Name = "Adesso Porto"
                        },
                        new
                        {
                            Id = 19,
                            CountryId = 5,
                            Name = "Adesso Braga"
                        },
                        new
                        {
                            Id = 20,
                            CountryId = 5,
                            Name = "Adesso Coimbra"
                        },
                        new
                        {
                            Id = 21,
                            CountryId = 6,
                            Name = "Adesso Roma"
                        },
                        new
                        {
                            Id = 22,
                            CountryId = 6,
                            Name = "Adesso Milano"
                        },
                        new
                        {
                            Id = 23,
                            CountryId = 6,
                            Name = "Adesso Venedik"
                        },
                        new
                        {
                            Id = 24,
                            CountryId = 6,
                            Name = "Adesso Napoli"
                        },
                        new
                        {
                            Id = 25,
                            CountryId = 7,
                            Name = "Adesso Sevilla"
                        },
                        new
                        {
                            Id = 26,
                            CountryId = 7,
                            Name = "Adesso Madrid"
                        },
                        new
                        {
                            Id = 27,
                            CountryId = 7,
                            Name = "Adesso Barselona"
                        },
                        new
                        {
                            Id = 28,
                            CountryId = 7,
                            Name = "Adesso Granada"
                        },
                        new
                        {
                            Id = 29,
                            CountryId = 8,
                            Name = "Adesso Brüksel"
                        },
                        new
                        {
                            Id = 30,
                            CountryId = 8,
                            Name = "Adesso Brugge"
                        },
                        new
                        {
                            Id = 31,
                            CountryId = 8,
                            Name = "Adesso Gent"
                        },
                        new
                        {
                            Id = 32,
                            CountryId = 8,
                            Name = "Adesso Anvers"
                        });
                });

            modelBuilder.Entity("AdessoWorldLeauge.Domain.Entities.Group", b =>
                {
                    b.HasOne("AdessoWorldLeauge.Domain.Entities.Draw", "Draw")
                        .WithOne("Group")
                        .HasForeignKey("AdessoWorldLeauge.Domain.Entities.Group", "DrawId");

                    b.Navigation("Draw");
                });

            modelBuilder.Entity("AdessoWorldLeauge.Domain.Entities.Team", b =>
                {
                    b.HasOne("AdessoWorldLeauge.Domain.Entities.Country", "Country")
                        .WithMany("Teams")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AdessoWorldLeauge.Domain.Entities.Group", "Group")
                        .WithMany("Teams")
                        .HasForeignKey("GroupId");

                    b.Navigation("Country");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("AdessoWorldLeauge.Domain.Entities.Country", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("AdessoWorldLeauge.Domain.Entities.Draw", b =>
                {
                    b.Navigation("Group")
                        .IsRequired();
                });

            modelBuilder.Entity("AdessoWorldLeauge.Domain.Entities.Group", b =>
                {
                    b.Navigation("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}