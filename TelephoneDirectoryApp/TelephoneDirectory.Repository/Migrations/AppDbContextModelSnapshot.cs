﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TelephoneDirectory.Repository;

#nullable disable

namespace TelephoneDirectory.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TelephoneDirectory.Core.Models.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Şirketler"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Üniversiteler"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sağlık Kuruluşları"
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Oteller"
                        });
                });

            modelBuilder.Entity("TelephoneDirectory.Core.Models.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreateDate = new DateTime(2022, 12, 15, 1, 14, 14, 842, DateTimeKind.Local).AddTicks(273),
                            Name = "Kalem",
                            Price = 60m,
                            Stock = 20
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreateDate = new DateTime(2022, 12, 15, 1, 14, 14, 842, DateTimeKind.Local).AddTicks(284),
                            Name = "Kağıt",
                            Price = 80m,
                            Stock = 4
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreateDate = new DateTime(2022, 12, 15, 1, 14, 14, 842, DateTimeKind.Local).AddTicks(285),
                            Name = "Defter",
                            Price = 90m,
                            Stock = 5
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            CreateDate = new DateTime(2022, 12, 15, 1, 14, 14, 842, DateTimeKind.Local).AddTicks(287),
                            Name = "Klavye",
                            Price = 100m,
                            Stock = 6
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            CreateDate = new DateTime(2022, 12, 15, 1, 14, 14, 842, DateTimeKind.Local).AddTicks(288),
                            Name = "Mause",
                            Price = 215m,
                            Stock = 7
                        });
                });

            modelBuilder.Entity("TelephoneDirectory.Core.Models.Entities.ProductFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductFeatures");
                });

            modelBuilder.Entity("TelephoneDirectory.Core.Models.Entities.Product", b =>
                {
                    b.HasOne("TelephoneDirectory.Core.Models.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("TelephoneDirectory.Core.Models.Entities.ProductFeature", b =>
                {
                    b.HasOne("TelephoneDirectory.Core.Models.Entities.Product", "Product")
                        .WithOne("ProductFeature")
                        .HasForeignKey("TelephoneDirectory.Core.Models.Entities.ProductFeature", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("TelephoneDirectory.Core.Models.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("TelephoneDirectory.Core.Models.Entities.Product", b =>
                {
                    b.Navigation("ProductFeature");
                });
#pragma warning restore 612, 618
        }
    }
}
