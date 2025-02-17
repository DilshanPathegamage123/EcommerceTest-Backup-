﻿// <auto-generated />
using System;
using Ecommerce.ReviewAndRating.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.ReviewAndRating.Infrastructure.Migrations
{
    [DbContext(typeof(ReviewAndRatingDbContext))]
    partial class ReviewAndRatingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecommerce.ReviewAndRating.Domain.Models.Feedback", b =>
                {
                    b.Property<int>("feedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("feedbackId"));

                    b.Property<string>("feedbackMessage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("givenDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("orderId")
                        .HasColumnType("int");

                    b.Property<double>("rate")
                        .HasColumnType("float");

                    b.HasKey("feedbackId");

                    b.HasIndex("orderId");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("Ecommerce.ReviewAndRating.Domain.Models.FeedbackWithProduct", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("feedbackId")
                        .HasColumnType("int");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("FeedbackWithProduct");
                });

            modelBuilder.Entity("Ecommerce.ReviewAndRating.Domain.Models.Order", b =>
                {
                    b.Property<int>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("orderId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserModelId")
                        .HasColumnType("int");

                    b.Property<string>("paymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("paymentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("phoneNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("postalcode")
                        .HasColumnType("int");

                    b.Property<float>("totalPrice")
                        .HasColumnType("real");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("orderId");

                    b.HasIndex("UserModelId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Ecommerce.ReviewAndRating.Domain.Models.OrderProduct", b =>
                {
                    b.Property<int>("orderProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("orderProductId"));

                    b.Property<int>("count")
                        .HasColumnType("int");

                    b.Property<int>("orderId")
                        .HasColumnType("int");

                    b.Property<string>("pizzaSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.HasKey("orderProductId");

                    b.HasIndex("orderId");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("Ecommerce.userManage.Domain.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserModel");
                });

            modelBuilder.Entity("Ecommerce.ReviewAndRating.Domain.Models.Feedback", b =>
                {
                    b.HasOne("Ecommerce.ReviewAndRating.Domain.Models.Order", null)
                        .WithMany("Feedback")
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ecommerce.ReviewAndRating.Domain.Models.Order", b =>
                {
                    b.HasOne("Ecommerce.userManage.Domain.Models.UserModel", "UserModel")
                        .WithMany()
                        .HasForeignKey("UserModelId");

                    b.Navigation("UserModel");
                });

            modelBuilder.Entity("Ecommerce.ReviewAndRating.Domain.Models.OrderProduct", b =>
                {
                    b.HasOne("Ecommerce.ReviewAndRating.Domain.Models.Order", "Order")
                        .WithMany("OrderProduct")
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Ecommerce.ReviewAndRating.Domain.Models.Order", b =>
                {
                    b.Navigation("Feedback");

                    b.Navigation("OrderProduct");
                });
#pragma warning restore 612, 618
        }
    }
}
