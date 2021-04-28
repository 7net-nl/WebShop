﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TShop.Infrascture.DataBase.EF;

namespace TShop.Infrascture.DataBase.EF.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TShop.Domain.Entities.Category", b =>
                {
                    b.Property<byte>("ID");

                    b.Property<DateTime>("InsertDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("ID");

                    b.HasIndex("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = (byte)1,
                            InsertDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Tshirt",
                            UpdateDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            ID = (byte)2,
                            InsertDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Shoes",
                            UpdateDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            ID = (byte)3,
                            InsertDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Jeans",
                            UpdateDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            ID = (byte)4,
                            InsertDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Dress",
                            UpdateDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("TShop.Domain.Entities.ImageFile", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<DateTime>("InsertDate");

                    b.Property<long>("Product_ID");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("ID");

                    b.HasIndex("ID");

                    b.HasIndex("Product_ID");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            FileName = "a3.jpg",
                            InsertDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Product_ID = 1L,
                            UpdateDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            ID = 2L,
                            FileName = "1.jpg",
                            InsertDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Product_ID = 1L,
                            UpdateDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            ID = 3L,
                            FileName = "2.jpg",
                            InsertDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Product_ID = 1L,
                            UpdateDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            ID = 4L,
                            FileName = "3.jpg",
                            InsertDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Product_ID = 1L,
                            UpdateDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("TShop.Domain.Entities.Product", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Available");

                    b.Property<byte>("Category_ID");

                    b.Property<DateTime>("InsertDate");

                    b.Property<string>("LongDescription")
                        .IsRequired()
                        .HasMaxLength(4000);

                    b.Property<decimal>("NewPrice");

                    b.Property<decimal>("OldPrice");

                    b.Property<byte>("Rank");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("ID");

                    b.HasIndex("Category_ID");

                    b.HasIndex("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            Available = 0,
                            Category_ID = (byte)1,
                            InsertDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            LongDescription = "Sed ut eros felis. Vestibulum rutrum imperdiet nunc a interdum. In scelerisque libero ut elit porttitor commodo. Suspendisse laoreet magna nec urna fringilla viverra.100% Cotton",
                            NewPrice = 50m,
                            OldPrice = 70m,
                            Rank = (byte)4,
                            ShortDescription = "Vestibulum rutrum imperdiet nunc a interdum",
                            Title = "Product Name",
                            UpdateDate = new DateTime(2019, 4, 9, 7, 25, 10, 489, DateTimeKind.Local).AddTicks(7023)
                        });
                });

            modelBuilder.Entity("TShop.Domain.Entities.ProductColor", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("InsertDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<long>("Product_ID");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("ID");

                    b.HasIndex("ID");

                    b.HasIndex("Product_ID");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            InsertDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Red",
                            Product_ID = 1L,
                            UpdateDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            ID = 2L,
                            InsertDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Blue",
                            Product_ID = 1L,
                            UpdateDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            ID = 3L,
                            InsertDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Pink",
                            Product_ID = 1L,
                            UpdateDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("TShop.Domain.Entities.ProductSize", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("InsertDate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<long>("Product_ID");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("ID");

                    b.HasIndex("ID");

                    b.HasIndex("Product_ID");

                    b.ToTable("Sizes");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            InsertDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "S",
                            Product_ID = 1L,
                            UpdateDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            ID = 2L,
                            InsertDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "M",
                            Product_ID = 1L,
                            UpdateDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            ID = 3L,
                            InsertDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "L",
                            Product_ID = 1L,
                            UpdateDate = new DateTime(2019, 4, 9, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("TShop.Domain.Entities.ImageFile", b =>
                {
                    b.HasOne("TShop.Domain.Entities.Product")
                        .WithMany("Images")
                        .HasForeignKey("Product_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TShop.Domain.Entities.Product", b =>
                {
                    b.HasOne("TShop.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("Category_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TShop.Domain.Entities.ProductColor", b =>
                {
                    b.HasOne("TShop.Domain.Entities.Product")
                        .WithMany("Colors")
                        .HasForeignKey("Product_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TShop.Domain.Entities.ProductSize", b =>
                {
                    b.HasOne("TShop.Domain.Entities.Product")
                        .WithMany("Sizes")
                        .HasForeignKey("Product_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}