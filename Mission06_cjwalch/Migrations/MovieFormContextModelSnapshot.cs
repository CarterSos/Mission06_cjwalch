﻿// <auto-generated />
using DateMe.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mission06_cjwalch.Migrations
{
    [DbContext(typeof(MovieFormContext))]
    partial class MovieFormContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("DateMe.Models.ApplicationResponse", b =>
                {
                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

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

                    b.HasIndex("CategoryId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            Title = "Avengers: Endgame",
                            CategoryId = 1,
                            Director = "Russo Brothers",
                            Edited = false,
                            Notes = "Greatest Movie ever",
                            Rating = "PG-13",
                            Year = 2019
                        },
                        new
                        {
                            Title = "Spiderman: Into the Spider-verse",
                            CategoryId = 1,
                            Director = "Bob Persichetti",
                            Edited = false,
                            Rating = "PG",
                            Year = 2018
                        },
                        new
                        {
                            Title = "The Count of Monte Cristo",
                            CategoryId = 2,
                            Director = "Kevin Reynolds",
                            Edited = false,
                            Notes = "Best revenge story",
                            Rating = "PG-13",
                            Year = 2002
                        });
                });

            modelBuilder.Entity("Mission06_cjwalch.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Adventure"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Romance"
                        });
                });

            modelBuilder.Entity("DateMe.Models.ApplicationResponse", b =>
                {
                    b.HasOne("Mission06_cjwalch.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}