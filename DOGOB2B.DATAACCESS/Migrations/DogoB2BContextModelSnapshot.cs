﻿// <auto-generated />
using System;
using DOGOB2B.DATAACCESS.Concrete.Entity_Framework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DOGOB2B.DATAACCESS.Migrations
{
    [DbContext(typeof(DogoB2BContext))]
    partial class DogoB2BContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DOGOB2B.ENTITY.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ayakkabı"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Üst Giyim"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Aksesuar"
                        });
                });

            modelBuilder.Entity("DOGOB2B.ENTITY.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BottomProductGroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemDim1Code")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainProductGroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PicturePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("Money");

                    b.Property<string>("ProductModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Barcode = "8680544164738",
                            BottomProductGroup = "Boots",
                            Gender = "Women",
                            ItemCode = "dgs018-box064",
                            ItemDim1Code = 39,
                            ItemName = "Women Vegan Leather Gray Ankle Boots - Lost Design",
                            MainProductGroup = "Shoes",
                            PicturePath = "https://www.dogostore.com/Data/K/D25/1473.jpg",
                            Price = 600m,
                            ProductModel = "Boxford",
                            Stock = 14
                        },
                        new
                        {
                            Id = 2,
                            Barcode = "8680544215942",
                            BottomProductGroup = "Flat Shoes",
                            Gender = "Women",
                            ItemCode = "dgs020-myr022",
                            ItemDim1Code = 40,
                            ItemName = "Women Vegan Leather Beige Sneakers - Call me Hotdog Design",
                            MainProductGroup = "Shoes",
                            PicturePath = "https://www.dogostore.com/Data/K/D11/7691.jpg",
                            Price = 650m,
                            ProductModel = "Myra",
                            Stock = 20
                        },
                        new
                        {
                            Id = 3,
                            Barcode = "8680544077700",
                            BottomProductGroup = "Boots",
                            Gender = "Women",
                            ItemCode = "dgs014-lb008",
                            ItemDim1Code = 38,
                            ItemName = "Women Vegan Leather Green Long Boots - Koala Hug Design",
                            MainProductGroup = "Shoes",
                            PicturePath = "https://www.dogostore.com/Data/K/D51/13035.jpg",
                            Price = 750m,
                            ProductModel = "Long Boots",
                            Stock = 45
                        },
                        new
                        {
                            Id = 4,
                            Barcode = "8680544086696",
                            BottomProductGroup = "Boots",
                            Gender = "Women",
                            ItemCode = "dgs014-lb034",
                            ItemDim1Code = 39,
                            ItemName = "Women Vegan Leather Beige Long Boots - Catch Me Baby Design",
                            MainProductGroup = "Shoes",
                            PicturePath = "https://www.dogostore.com/Data/K/D51/3181.jpg",
                            Price = 750m,
                            ProductModel = "Long Boots",
                            Stock = 15
                        },
                        new
                        {
                            Id = 5,
                            Barcode = "8680544077021",
                            BottomProductGroup = "Boots",
                            Gender = "Women",
                            ItemCode = "dgs014-sb017",
                            ItemDim1Code = 38,
                            ItemName = "Women Vegan Leather Beige Ankle Boots - Purple Blue And Blue Design",
                            MainProductGroup = "Shoes",
                            PicturePath = "https://www.dogostore.com/Data/K/D21/1194.jpg",
                            Price = 600m,
                            ProductModel = "Short Boots",
                            Stock = 23
                        },
                        new
                        {
                            Id = 6,
                            Barcode = "8680544201259",
                            BottomProductGroup = "Sandals",
                            Gender = "Women",
                            ItemCode = "dgs020-hzl025",
                            ItemDim1Code = 40,
                            ItemName = "Women Vegan Leather Blue Lace Up Sandals - Les Papillons Design",
                            MainProductGroup = "Shoes",
                            PicturePath = "https://www.dogostore.com/Data/K/D75/5043.jpg",
                            Price = 680m,
                            ProductModel = "Hazel",
                            Stock = 11
                        },
                        new
                        {
                            Id = 7,
                            Barcode = "8680544246588",
                            BottomProductGroup = "Flat Shoes",
                            Gender = "Men",
                            ItemCode = "dgs023-acem008",
                            ItemDim1Code = 42,
                            ItemName = "Men Vegan Leather White Sneakers - Equal Design",
                            MainProductGroup = "Shoes",
                            PicturePath = "https://www.dogostore.com/Data/K/D24/13763.jpg",
                            Price = 724m,
                            ProductModel = "Ace Sneakers Men",
                            Stock = 11
                        },
                        new
                        {
                            Id = 8,
                            Barcode = "8680544247905",
                            BottomProductGroup = "Flat Shoes",
                            Gender = "Men",
                            ItemCode = "dgsnk023-028",
                            ItemDim1Code = 43,
                            ItemName = "Time Waits for No-one / Dogo Sneakers Men s Shoes",
                            MainProductGroup = "Shoes",
                            PicturePath = "https://www.dogostore.com/Data/K/D24/14030.jpg",
                            Price = 730m,
                            ProductModel = "Men Sneakers",
                            Stock = 31
                        },
                        new
                        {
                            Id = 9,
                            Barcode = "8680544246632",
                            BottomProductGroup = "Flat Shoes",
                            Gender = "Men",
                            ItemCode = "dgs023-acem009",
                            ItemDim1Code = 42,
                            ItemName = "Men Vegan Leather White Sneakers - Meet me Halfway Design",
                            MainProductGroup = "Shoes",
                            PicturePath = "https://www.dogostore.com/Data/K/D24/13770.jpg",
                            Price = 724m,
                            ProductModel = "Ace Sneakers Men",
                            Stock = 43
                        });
                });

            modelBuilder.Entity("DOGOB2B.ENTITY.Concrete.ShoppingCardItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCardItems", (string)null);
                });

            modelBuilder.Entity("DOGOB2B.ENTITY.Concrete.ShoppingCardItem", b =>
                {
                    b.HasOne("DOGOB2B.ENTITY.Concrete.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
