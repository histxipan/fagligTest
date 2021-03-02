﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiNinjectStudio.Domain.Concrete;

namespace WebApiNinjectStudio.Domain.Migrations
{
    [DbContext(typeof(EFDbContext))]
    [Migration("20210302093909_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiNinjectStudio.Domain.Entities.ApiUrl", b =>
                {
                    b.Property<int>("ApiUrlID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApiRequestMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApiUrlRegex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApiUrlString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("ApiUrlID");

                    b.ToTable("ApiUrls");

                    b.HasData(
                        new
                        {
                            ApiUrlID = 1,
                            ApiRequestMethod = "Get",
                            ApiUrlString = "/api/User",
                            IsDeleted = false
                        },
                        new
                        {
                            ApiUrlID = 2,
                            ApiRequestMethod = "Get",
                            ApiUrlString = "/api/User/GetUserID",
                            IsDeleted = false
                        },
                        new
                        {
                            ApiUrlID = 3,
                            ApiRequestMethod = "Get",
                            ApiUrlString = "/api/product",
                            IsDeleted = false
                        },
                        new
                        {
                            ApiUrlID = 4,
                            ApiRequestMethod = "Post",
                            ApiUrlString = "/api/product",
                            IsDeleted = false
                        },
                        new
                        {
                            ApiUrlID = 5,
                            ApiRequestMethod = "Post",
                            ApiUrlRegex = "^\\/api\\/v1\\/categories$",
                            ApiUrlString = "/api/v1/categories",
                            Description = "Create category",
                            IsDeleted = false
                        },
                        new
                        {
                            ApiUrlID = 6,
                            ApiRequestMethod = "Get",
                            ApiUrlRegex = "^\\/api\\/v1\\/categories$",
                            ApiUrlString = "/api/v1/categories",
                            Description = "Get category list",
                            IsDeleted = false
                        },
                        new
                        {
                            ApiUrlID = 7,
                            ApiRequestMethod = "Get",
                            ApiUrlRegex = "^\\/api\\/v1\\/categories\\/\\d+$",
                            ApiUrlString = "/api/v1/categories/{categoryId}",
                            Description = "Get info about category by category id",
                            IsDeleted = false
                        },
                        new
                        {
                            ApiUrlID = 8,
                            ApiRequestMethod = "Delete",
                            ApiUrlRegex = "^\\/api\\/v1\\/categories\\/\\d+$",
                            ApiUrlString = "/api/v1/categories/{categoryId}",
                            Description = "Delete category by identifier",
                            IsDeleted = false
                        },
                        new
                        {
                            ApiUrlID = 9,
                            ApiRequestMethod = "Put",
                            ApiUrlRegex = "^\\/api\\/v1\\/categories\\/\\d+$",
                            ApiUrlString = "/api/v1/categories/{categoryId}",
                            Description = "Update category by identifier",
                            IsDeleted = false
                        },
                        new
                        {
                            ApiUrlID = 10,
                            ApiRequestMethod = "Post",
                            ApiUrlRegex = "^\\/api\\/v1\\/categories\\/\\d+\\/products$",
                            ApiUrlString = "/api/v1/categories/{categoryId}/products",
                            Description = "Assign a product to the required category",
                            IsDeleted = false
                        },
                        new
                        {
                            ApiUrlID = 11,
                            ApiRequestMethod = "Get",
                            ApiUrlRegex = "^\\/api\\/v1\\/categories\\/\\d+\\/products(\\?.*)*$",
                            ApiUrlString = "/api/v1/categories/{categoryId}/products",
                            Description = "Get products assigned to category",
                            IsDeleted = false
                        },
                        new
                        {
                            ApiUrlID = 12,
                            ApiRequestMethod = "Put",
                            ApiUrlRegex = "^\\/api\\/v1\\/categories\\/\\d+\\/products$",
                            ApiUrlString = "/api/v1/categories/{categoryId}/products",
                            Description = "Assign a product to the required category",
                            IsDeleted = false
                        },
                        new
                        {
                            ApiUrlID = 13,
                            ApiRequestMethod = "Delete",
                            ApiUrlRegex = "^\\/api\\/v1\\/categories\\/\\d+\\/products\\/\\d+$",
                            ApiUrlString = "/api/v1/categories/{categoryId}/products/{productId}",
                            Description = "Remove the product assignment from the category by category id and product id",
                            IsDeleted = false
                        },
                        new
                        {
                            ApiUrlID = 14,
                            ApiRequestMethod = "Get",
                            ApiUrlRegex = "^\\/api\\/v1\\/products(\\?.*)*$",
                            ApiUrlString = "/api/v1/products",
                            Description = "Get product list",
                            IsDeleted = false
                        },
                        new
                        {
                            ApiUrlID = 15,
                            ApiRequestMethod = "Post",
                            ApiUrlRegex = "^\\/api\\/v1\\/products$",
                            ApiUrlString = "/api/v1/products",
                            Description = "Create product",
                            IsDeleted = false
                        },
                        new
                        {
                            ApiUrlID = 16,
                            ApiRequestMethod = "Get",
                            ApiUrlRegex = "^\\/api\\/v1\\/products\\/\\d+$",
                            ApiUrlString = "/api/v1/products/{productId}",
                            Description = "Get info about product by product id",
                            IsDeleted = false
                        },
                        new
                        {
                            ApiUrlID = 17,
                            ApiRequestMethod = "Put",
                            ApiUrlRegex = "^\\/api\\/v1\\/products\\/\\d+$",
                            ApiUrlString = "/api/v1/products/{productId}",
                            Description = "Update the product by product id",
                            IsDeleted = false
                        },
                        new
                        {
                            ApiUrlID = 18,
                            ApiRequestMethod = "Delete",
                            ApiUrlRegex = "^\\/api\\/v1\\/products\\/\\d+$",
                            ApiUrlString = "/api/v1/products/{productId}",
                            Description = "Remove the product by product id",
                            IsDeleted = false
                        },
                        new
                        {
                            ApiUrlID = 19,
                            ApiRequestMethod = "Get",
                            ApiUrlRegex = "^\\/api\\/v1\\/integrations\\/customer\\/userid$",
                            ApiUrlString = "/api/v1/integrations/customer/userid",
                            Description = "Get id of current user.",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("WebApiNinjectStudio.Domain.Entities.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1,
                            Description = "Lorem Ipsum is simply dummy text",
                            IsDeleted = false,
                            Name = "Kontorstol REGSTRUP",
                            Price = 300m
                        },
                        new
                        {
                            ProductID = 2,
                            Description = "Barstol KLARUP",
                            IsDeleted = false,
                            Name = "Barstol KLARUP",
                            Price = 250m
                        },
                        new
                        {
                            ProductID = 3,
                            Description = "Lorem Ipsum is simply dummy text",
                            IsDeleted = false,
                            Name = "iPhone 12",
                            Price = 7250m
                        },
                        new
                        {
                            ProductID = 4,
                            Description = "Lorem Ipsum is simply dummy text",
                            IsDeleted = false,
                            Name = "Nokia Lumia 3000",
                            Price = 1420m
                        },
                        new
                        {
                            ProductID = 5,
                            Description = "Lorem Ipsum is simply dummy text",
                            IsDeleted = false,
                            Name = "Tomat",
                            Price = 20m
                        });
                });

            modelBuilder.Entity("WebApiNinjectStudio.Domain.Entities.ProductImage", b =>
                {
                    b.Property<int>("ProductImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductImageId");

                    b.HasIndex("ProductID")
                        .IsUnique();

                    b.ToTable("ProductImages");

                    b.HasData(
                        new
                        {
                            ProductImageId = 1,
                            IsDeleted = false,
                            ProductID = 1,
                            Url = "jysk.dk/kontor/kontorstole/basic/kontorstol-regstrup-sort-graa"
                        },
                        new
                        {
                            ProductImageId = 2,
                            IsDeleted = false,
                            ProductID = 2,
                            Url = "jysk.dk/spisestue/barborde-stole/barstol-klarup-sort-krom-0"
                        });
                });

            modelBuilder.Entity("WebApiNinjectStudio.Domain.Entities.ProductTag", b =>
                {
                    b.Property<int>("ProductTagID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("ProductTagID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductTags");

                    b.HasData(
                        new
                        {
                            ProductTagID = 1,
                            IsDeleted = false,
                            Name = "Bremsehjul",
                            ProductID = 1
                        },
                        new
                        {
                            ProductTagID = 2,
                            IsDeleted = false,
                            Name = "Højdejusterbar",
                            ProductID = 1
                        },
                        new
                        {
                            ProductTagID = 3,
                            IsDeleted = false,
                            Name = "Skum",
                            ProductID = 2
                        },
                        new
                        {
                            ProductTagID = 4,
                            IsDeleted = false,
                            Name = "Metal",
                            ProductID = 2
                        },
                        new
                        {
                            ProductTagID = 5,
                            IsDeleted = false,
                            Name = "6,1",
                            ProductID = 3
                        },
                        new
                        {
                            ProductTagID = 6,
                            IsDeleted = false,
                            Name = "5G",
                            ProductID = 3
                        });
                });

            modelBuilder.Entity("WebApiNinjectStudio.Domain.Entities.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            IsDeleted = false,
                            Name = "Administrator"
                        },
                        new
                        {
                            RoleID = 2,
                            IsDeleted = false,
                            Name = "Guest"
                        });
                });

            modelBuilder.Entity("WebApiNinjectStudio.Domain.Entities.RolePermissionApiUrl", b =>
                {
                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<int>("ApiUrlID")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("RoleID", "ApiUrlID");

                    b.HasIndex("ApiUrlID");

                    b.ToTable("RolePermissionApiUrls");

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            ApiUrlID = 1,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 1,
                            ApiUrlID = 2,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 1,
                            ApiUrlID = 3,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 1,
                            ApiUrlID = 4,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 1,
                            ApiUrlID = 5,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 1,
                            ApiUrlID = 6,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 1,
                            ApiUrlID = 7,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 1,
                            ApiUrlID = 8,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 1,
                            ApiUrlID = 9,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 1,
                            ApiUrlID = 10,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 1,
                            ApiUrlID = 11,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 1,
                            ApiUrlID = 12,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 1,
                            ApiUrlID = 13,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 1,
                            ApiUrlID = 14,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 1,
                            ApiUrlID = 15,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 1,
                            ApiUrlID = 16,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 1,
                            ApiUrlID = 17,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 1,
                            ApiUrlID = 18,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 1,
                            ApiUrlID = 19,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 2,
                            ApiUrlID = 3,
                            IsDeleted = false
                        },
                        new
                        {
                            RoleID = 2,
                            ApiUrlID = 4,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("WebApiNinjectStudio.Domain.Entities.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.HasIndex("RoleID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            Email = "one@gmail.com",
                            FirstName = "Kim",
                            IsDeleted = false,
                            LastName = "Nielsen",
                            Password = "M4jZrsPV2wNAeOH1YooKUdALx6Ek0DJaMf8yoiYI0Mc=",
                            RoleID = 1
                        },
                        new
                        {
                            UserID = 2,
                            Email = "two@gmail.com",
                            FirstName = "Martin",
                            IsDeleted = false,
                            LastName = "Jensen",
                            Password = "FOHqRDbYuVdIBvLS6r2YMVU4Yu7E54DJJJxrWGh5YZc=",
                            RoleID = 2
                        });
                });

            modelBuilder.Entity("WebApiNinjectStudio.Domain.Entities.ProductImage", b =>
                {
                    b.HasOne("WebApiNinjectStudio.Domain.Entities.Product", "Product")
                        .WithOne("ProductImage")
                        .HasForeignKey("WebApiNinjectStudio.Domain.Entities.ProductImage", "ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApiNinjectStudio.Domain.Entities.ProductTag", b =>
                {
                    b.HasOne("WebApiNinjectStudio.Domain.Entities.Product", "Product")
                        .WithMany("ProductTag")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApiNinjectStudio.Domain.Entities.RolePermissionApiUrl", b =>
                {
                    b.HasOne("WebApiNinjectStudio.Domain.Entities.ApiUrl", "ApiUrl")
                        .WithMany("RolePermissionApiUrls")
                        .HasForeignKey("ApiUrlID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiNinjectStudio.Domain.Entities.Role", "Role")
                        .WithMany("RolePermissionApiUrls")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApiNinjectStudio.Domain.Entities.User", b =>
                {
                    b.HasOne("WebApiNinjectStudio.Domain.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}