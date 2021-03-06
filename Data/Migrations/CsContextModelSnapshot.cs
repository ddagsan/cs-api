// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(CsContext))]
    partial class CsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Domain.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brand");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Samsung"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Nokia"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Apple"
                        },
                        new
                        {
                            Id = 4,
                            Name = "LG"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Huawei"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Xiaomi"
                        },
                        new
                        {
                            Id = 7,
                            Name = "General Mobile"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Oppo"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Vivo"
                        },
                        new
                        {
                            Id = 10,
                            Name = "HTC"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Unknown"
                        });
                });

            modelBuilder.Entity("Core.Domain.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("Core.Domain.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Color");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Lacivert"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sarı"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Siyah"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Beyaz"
                        });
                });

            modelBuilder.Entity("Core.Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<double>("DiscountRatio")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("ColorId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 3,
                            ColorId = 4,
                            DiscountRatio = 1.0,
                            Name = "Apple iPhone 11 Pro Maxi Phone 11 Pro Max iPhone 11 (Max 2 Line)",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 3,
                            ColorId = 2,
                            DiscountRatio = 1.0,
                            Name = "Apple iPhone 11",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 3,
                            ColorId = 2,
                            DiscountRatio = 1.0,
                            Name = "iPhone 11 Kırmızı Kılıf",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 1,
                            ColorId = 2,
                            DiscountRatio = 1.0,
                            Name = "Samsung Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 1,
                            ColorId = 4,
                            DiscountRatio = 1.0,
                            Name = "Samsung Telefon 1",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 5,
                            ColorId = 2,
                            DiscountRatio = 1.0,
                            Name = "Huawei Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 7,
                            BrandId = 11,
                            ColorId = 3,
                            DiscountRatio = 1.0,
                            Name = "Xiaomi Redmi Note 10S 128 GB 6 GB Ram",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 8,
                            BrandId = 11,
                            ColorId = 4,
                            DiscountRatio = 1.0,
                            Name = "Oppo Reno Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 9,
                            BrandId = 11,
                            ColorId = 2,
                            DiscountRatio = 1.0,
                            Name = "Xiomi Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 10,
                            BrandId = 11,
                            ColorId = 3,
                            DiscountRatio = 1.0,
                            Name = "Oppo Reno 5 Lite 128 GB",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 11,
                            BrandId = 5,
                            ColorId = 4,
                            DiscountRatio = 1.0,
                            Name = "Huawei Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 12,
                            BrandId = 3,
                            ColorId = 1,
                            DiscountRatio = 1.0,
                            Name = "Apple Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 13,
                            BrandId = 5,
                            ColorId = 2,
                            DiscountRatio = 1.0,
                            Name = "Huawei Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 14,
                            BrandId = 5,
                            ColorId = 3,
                            DiscountRatio = 1.0,
                            Name = "Huawei Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 15,
                            BrandId = 11,
                            ColorId = 4,
                            DiscountRatio = 1.0,
                            Name = "HTC Desire 20 Pro",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 16,
                            BrandId = 5,
                            ColorId = 2,
                            DiscountRatio = 1.0,
                            Name = "Huawei Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 17,
                            BrandId = 3,
                            ColorId = 3,
                            DiscountRatio = 1.0,
                            Name = "Apple Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 18,
                            BrandId = 11,
                            ColorId = 4,
                            DiscountRatio = 1.0,
                            Name = "HTC Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 19,
                            BrandId = 11,
                            ColorId = 1,
                            DiscountRatio = 1.0,
                            Name = "Oppo Reno Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 20,
                            BrandId = 4,
                            ColorId = 2,
                            DiscountRatio = 1.0,
                            Name = "LG Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 21,
                            BrandId = 11,
                            ColorId = 3,
                            DiscountRatio = 1.0,
                            Name = "Sonny Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 22,
                            BrandId = 11,
                            ColorId = 4,
                            DiscountRatio = 1.0,
                            Name = "General Mobile",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 23,
                            BrandId = 11,
                            ColorId = 1,
                            DiscountRatio = 1.0,
                            Name = "Tecno Spark Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 24,
                            BrandId = 1,
                            ColorId = 2,
                            DiscountRatio = 1.0,
                            Name = "Samsung Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 25,
                            BrandId = 11,
                            ColorId = 3,
                            DiscountRatio = 1.0,
                            Name = "Xiaomı Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 26,
                            BrandId = 11,
                            ColorId = 4,
                            DiscountRatio = 1.0,
                            Name = "ViVo Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 27,
                            BrandId = 5,
                            ColorId = 1,
                            DiscountRatio = 1.0,
                            Name = "Huawei Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 28,
                            BrandId = 3,
                            ColorId = 2,
                            DiscountRatio = 1.0,
                            Name = "Apple Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 29,
                            BrandId = 1,
                            ColorId = 3,
                            DiscountRatio = 1.0,
                            Name = "Samsung Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 30,
                            BrandId = 4,
                            ColorId = 4,
                            DiscountRatio = 1.0,
                            Name = "LG Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 31,
                            BrandId = 11,
                            ColorId = 4,
                            DiscountRatio = 1.0,
                            Name = "Oppo Reno Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 32,
                            BrandId = 1,
                            ColorId = 4,
                            DiscountRatio = 1.0,
                            Name = "Samsung Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 33,
                            BrandId = 11,
                            ColorId = 4,
                            DiscountRatio = 1.0,
                            Name = "HTC Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 34,
                            BrandId = 11,
                            ColorId = 4,
                            DiscountRatio = 1.0,
                            Name = "HTC Telefon 2",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 35,
                            BrandId = 11,
                            ColorId = 4,
                            DiscountRatio = 1.0,
                            Name = "HTC Phone 4",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 36,
                            BrandId = 11,
                            ColorId = 2,
                            DiscountRatio = 1.0,
                            Name = "HTC teleFON 9",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 37,
                            BrandId = 11,
                            ColorId = 4,
                            DiscountRatio = 1.0,
                            Name = "Samsung Telefon",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 38,
                            BrandId = 11,
                            ColorId = 4,
                            DiscountRatio = 1.0,
                            Name = "HTC Telefon 50",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 39,
                            BrandId = 11,
                            ColorId = 4,
                            DiscountRatio = 1.0,
                            Name = "HTC Telefon 98",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 40,
                            BrandId = 11,
                            ColorId = 4,
                            DiscountRatio = 1.0,
                            Name = "HTC Telefon 100",
                            Price = 1000.0
                        });
                });

            modelBuilder.Entity("Core.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Username = "CsUser"
                        });
                });

            modelBuilder.Entity("Core.Domain.Cart", b =>
                {
                    b.HasOne("Core.Domain.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.User", "User")
                        .WithMany("CartProducts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Domain.Product", b =>
                {
                    b.HasOne("Core.Domain.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Domain.Color", "Color")
                        .WithMany("Products")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Color");
                });

            modelBuilder.Entity("Core.Domain.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Core.Domain.Color", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Core.Domain.Product", b =>
                {
                    b.Navigation("Carts");
                });

            modelBuilder.Entity("Core.Domain.User", b =>
                {
                    b.Navigation("CartProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
