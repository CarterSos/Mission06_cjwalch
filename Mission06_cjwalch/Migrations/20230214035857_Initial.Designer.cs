﻿// <auto-generated />
using DateMe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mission06_cjwalch.Migrations
{
    [DbContext(typeof(DateApplicationContext))]
    [Migration("20230214035857_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("DateMe.Models.ApplicationResponse", b =>
                {
                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Title");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            Title = "Avengers: Endgame",
                            Category = "Action",
                            Director = "Russo Brothers",
                            Edited = false,
                            Notes = "Greatest Movie ever",
                            Rating = "PG-13",
                            Year = 2019
                        },
                        new
                        {
                            Title = "Spiderman: Into the Spider-verse",
                            Category = "Action",
                            Director = "Bob Persichetti",
                            Edited = false,
                            Rating = "PG",
                            Year = 2018
                        },
                        new
                        {
                            Title = "The Count of Monte Cristo",
                            Category = "Adventure",
                            Director = "Kevin Reynolds",
                            Edited = false,
                            Notes = "Best revenge story",
                            Rating = "PG-13",
                            Year = 2002
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
