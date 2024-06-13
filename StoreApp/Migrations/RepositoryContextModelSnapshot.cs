﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories.Models;

#nullable disable

namespace StoreApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Property<int>("categoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("categoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("categoryId");

                    b.ToTable("category");

                    b.HasData(
                        new
                        {
                            categoryId = 1,
                            categoryName = "Adidas"
                        },
                        new
                        {
                            categoryId = 2,
                            categoryName = "Nike"
                        });
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("categoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("imageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("productPrice")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("summary")
                        .HasColumnType("TEXT");

                    b.HasKey("productId");

                    b.HasIndex("categoryId");

                    b.ToTable("product");

                    b.HasData(
                        new
                        {
                            productId = 1,
                            categoryId = 2,
                            imageUrl = " /images/1.jpg",
                            productName = "Airforce Beyaz",
                            productPrice = 17000m,
                            summary = ""
                        },
                        new
                        {
                            productId = 2,
                            categoryId = 2,
                            imageUrl = "/images/2.jpg",
                            productName = "Airforce Beyaz Siyah",
                            productPrice = 10000m,
                            summary = ""
                        },
                        new
                        {
                            productId = 3,
                            categoryId = 2,
                            imageUrl = "/images/3.jpg",
                            productName = "Airforce Pudra",
                            productPrice = 20000m,
                            summary = ""
                        },
                        new
                        {
                            productId = 4,
                            categoryId = 2,
                            imageUrl = "/images/4.jpg",
                            productName = "Airforce Siyah",
                            productPrice = 15000m,
                            summary = ""
                        },
                        new
                        {
                            productId = 5,
                            categoryId = 2,
                            imageUrl = "/images/5.jpg",
                            productName = "Airforce Sİyah Beyaz",
                            productPrice = 16000m,
                            summary = ""
                        },
                        new
                        {
                            productId = 6,
                            categoryId = 1,
                            imageUrl = "/images/6.jpg",
                            productName = "Adidas Run",
                            productPrice = 18000m,
                            summary = ""
                        },
                        new
                        {
                            productId = 7,
                            categoryId = 1,
                            imageUrl = "/images/7.jpg",
                            productName = "Adidas Samba",
                            productPrice = 18000m,
                            summary = ""
                        });
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.HasOne("Entities.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("categoryId");

                    b.Navigation("category");
                });
#pragma warning restore 612, 618
        }
    }
}
